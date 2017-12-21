using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using GeneWinForms.Tools;
using GeneWinForms.Extensions;
using GeneWinForms.Proxy.Interceptors;

namespace GeneWinForms.Proxy.Descriptors
{
    internal class Method : IMethod
    {
        private List<InterceptorIdentity> interceptors;
        private Optional<System.Type> respositoryType;
        private DataAccess dataAccess;

        internal Method()
        { }

        public Method(MethodInfo methodInfo, Property propertyInfo)
        {
            Validator.IsNotNull<ArgumentException>(methodInfo, "methodInfo");
            Validator.IsNotNull<ArgumentException>(propertyInfo, "propertyInfo");
            Methodsignature = methodInfo.ToString();
            Property = propertyInfo;
            interceptors = new List<InterceptorIdentity>();
            dataAccess = new DataAccess() 
            { 
                IsDao = false,
                Getter = methodInfo.IsGetter() ? Optional<Func<object, object>>.Of(propertyInfo.Info.CreateGetter()) : Optional<Func<object, object>>.Of(null),
                Setter = methodInfo.IsSetter() ? Optional<Action<object, object>>.Of(propertyInfo.Info.CreateSetter()) : Optional<Action<object, object>>.Of(null)
            };
            respositoryType = Optional<System.Type>.Of(null);
        }

        public static IMethod Create(MethodInfo methodInfo, Property propertyInfo)
        {
            return new Method(methodInfo, propertyInfo);
        }

        public string Methodsignature { get; private set; }

        public DataAccess Access
        {
            get { return dataAccess; }
        }

        public Optional<System.Type> RespositoryType
        {
            get { return respositoryType; }
        }
        public Property Property { get; private set; }
        public InterceptorIdentity[] Interceptors
        {
            get
            {
                return interceptors.ToArray();
            }
        }

        public IMethod AddInterceptorIdentity(InterceptorIdentity interceptorIdentity)
        {
            if (!interceptors.Contains(interceptorIdentity)) interceptors.Add(interceptorIdentity);
            return this;
        }
    }

    internal interface IMethod
    {
        string Methodsignature { get; }
        DataAccess Access { get; }
        Optional<System.Type> RespositoryType { get; }
        IMethod AddInterceptorIdentity(InterceptorIdentity interceptorIdentity);
        Property Property { get; }
        InterceptorIdentity[] Interceptors { get; }  
    }

    internal class DataAccess
    {
        public bool IsDao { get; set; }
        public Optional<Action<object, object>> Setter { get; set; }
        public Optional<Func<object, object>> Getter { get; set; }
    }
}
