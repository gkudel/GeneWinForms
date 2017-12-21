using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using GeneWinForms.Tools;

namespace GeneWinForms.Proxy.Descriptors
{
    internal class ProxyMethod : IMethod
    {
        private IMethod method;
        private Optional<System.Type> repositoryType;

        private ProxyMethod(IMethod method)
        {
            Validator.IsNotNull<ArgumentException>(method, "method");
            this.method = method;            
        }

        public ProxyMethod(IMethod method, Action<object, object> setter)
            : this(method)
        {            
            Validator.IsNotNull<ArgumentException>(setter, "setter");
            method.Access.IsDao = true;
            this.Access.Setter = Optional<Action<object, object>>.Of(setter);
        }

        public ProxyMethod(IMethod method, Func<object, object> getter)
            : this(method)
        {
            Validator.IsNotNull<ArgumentException>(getter, "getter");
            method.Access.IsDao = true;
            method.Access.Getter = Optional<Func<object, object>>.Of(getter);
        }

        public ProxyMethod(IMethod method, System.Type repositoryType)
            : this(method)
        {
            Validator.IsNotNull<ArgumentException>(repositoryType, "repositoryType");
            this.repositoryType = Optional<System.Type>.Of(repositoryType);
        }

        public string Methodsignature
        {
            get { return method.Methodsignature; }
        }

        public DataAccess Access
        {
            get { return method.Access; }
        }

        public Property Property
        {
            get { return method.Property; }
        }

        public Optional<System.Type> RespositoryType
        {
            get { return repositoryType ?? method.RespositoryType; }
        }

        public Interceptors.InterceptorIdentity[] Interceptors
        {
            get { return method.Interceptors; }
        }

        public IMethod AddInterceptorIdentity(Interceptors.InterceptorIdentity interceptorIdentity)
        {
            method.AddInterceptorIdentity(interceptorIdentity);
            return this;
        }
    }
}
