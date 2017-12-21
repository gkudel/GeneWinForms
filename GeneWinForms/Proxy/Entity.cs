using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using GeneWinForms.Tools;
using System.ComponentModel;
using desc = GeneWinForms.Proxy.Descriptors;
using GeneWinForms.Extensions;
using GeneWinForms.Proxy.Interceptors;
using GeneWinForms.Proxy.Attributes;
using GeneWinForms.Repositories;

namespace GeneWinForms.Proxy
{
    public abstract class Entity : INotifyPropertyChanged
    {
        private static Dictionary<Type, desc.Type> Mapping;
        private static readonly object SynchMappingObject;
        private object dao;

        static Entity()
        {
            Mapping = new Dictionary<Type, desc.Type>();
            SynchMappingObject = new object();
        }

        public Entity(object dao)
        {
            Validator.IsNotNull<ArgumentException>(dao, "dao");
            TypeDesription = Init(GetType().BaseType);
            this.dao = dao;
        }

        internal desc.Type TypeDesription
        {
            get; private set;
        }

        public object DataObject
        {
            get
            {
                return dao;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private static desc.Type Init(Type enitityType)
        {
            if (Mapping.ContainsKey(enitityType)) return Mapping[enitityType];           
            lock (SynchMappingObject)
            {
                if (Mapping.ContainsKey(enitityType)) return Mapping[enitityType];

                var descriptors = new Dictionary<string, desc.IMethod>();
                foreach (var property in enitityType.GetProperties())
                {
                    var p = new desc.Property(property.Name, property);
                    if (property.CanRead && property.GetGetMethod() != null && property.GetGetMethod().IsVirtual)
                    {
                        var m = desc.Method.Create(property.GetGetMethod(), p);
                        var lazyLoadingAttribute = property.GetCustomAttribute<LazyLoadingAttribute>();
                        if (lazyLoadingAttribute != null)
                        {
                            if(!property.PropertyType.IsGenericType || property.PropertyType.GetGenericTypeDefinition() != typeof(IList<>)) throw new InvalidOperationException();

                            var repoositoryType = lazyLoadingAttribute.RepositoryType;
                            if (repoositoryType == null)
                            {
                                repoositoryType = typeof(IRelatedRepository<,>).MakeGenericType(new Type[] { enitityType, property.PropertyType.GetGenericArguments()[0] }); ;
                            }
                            m = new desc.ProxyMethod(m, repoositoryType);
                            m.AddInterceptorIdentity(InterceptorIdentity.LazyLoad);
                        }                        
                        descriptors.Add(property.GetGetSignature(), m.AddInterceptorIdentity(InterceptorIdentity.GetData));
                    }
                    if (property.CanWrite && property.GetSetMethod() != null && property.GetSetMethod().IsVirtual)
                    {
                        var m = desc.Method.Create(property.GetSetMethod(), p).AddInterceptorIdentity(InterceptorIdentity.SetData);
                        descriptors.Add(property.GetSetSignature(), m);
                    }
                }
                if (enitityType.BaseType != null && enitityType.BaseType.IsGenericType)
                {
                    var baseType = enitityType.BaseType.GetGenericArguments().FirstOrDefault();
                    foreach (var property in baseType.GetProperties())
                    {                        
                        if (property.CanRead && property.GetGetMethod() != null)
                        {
                            var signature = property.GetGetSignature();
                            if (descriptors.ContainsKey(signature))
                            {
                                var desc = descriptors[signature];
                                if (desc != null)
                                {
                                    descriptors[signature] = new desc.ProxyMethod(desc, property.CreateGetter());
                                }
                            }
                        }
                        if (property.CanWrite && property.GetSetMethod() != null)
                        {
                            var signature = property.GetSetSignature();
                            if (descriptors.ContainsKey(signature))
                            {
                                var desc = descriptors[signature];
                                if (desc != null)
                                {
                                    descriptors[signature] = new desc.ProxyMethod(desc, property.CreateSetter());
                                }
                            }
                        }
                    }
                }
                Mapping.Add(enitityType, new desc.Type(enitityType, descriptors.Values.ToList()));
            }
            return Mapping[enitityType];

        }

        internal static Descriptors.Type GetDescription<T>()
             where T : Entity
        {
            return GetDescription(typeof(T));
        }

        internal static Descriptors.Type GetDescription(Type type)
        {
            return Init(type);
        }
    }
}
