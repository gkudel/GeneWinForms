using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Tools;
using GeneWinForms.Extensions;
using GeneWinForms.Proxy.Interceptors;

namespace GeneWinForms.Proxy.Descriptors
{
    internal class Type
    {
        public Type(System.Type systemType, List<IMethod> methodsList)
        {
            Validator.IsNotNull<ArgumentException>(systemType, "systemType");
            var methods = methodsList ?? new List<IMethod>();
            Methods = new ReadOnlyDictionary<string, IMethod>(methods.ToDictionary(desc => desc.Methodsignature));
            var interceptorsSet = new HashSet<InterceptorIdentity>(methods.Where(p => p.Interceptors.IsNotEmpty())
                .SelectMany(p => p.Interceptors, (p, i) => i));
            Interceptors = interceptorsSet.ToArray();
            SystemType = systemType;
            foreach (var m in methods)
            {
                if (m.Access.Getter.IsPresent()) m.Property.GetMethod = m;
                else if (m.Access.Setter.IsPresent()) m.Property.SetMethod = m;
            }
        }

        public string Name { get { return SystemType.Name; } }
        public System.Type SystemType { get; private set; }
        public ReadOnlyDictionary<string, IMethod> Methods { get; private set; }
        public InterceptorIdentity[] Interceptors { get; private set; }
    }
}
