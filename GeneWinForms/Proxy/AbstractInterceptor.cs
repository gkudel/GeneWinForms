using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Proxy.Interceptors;

namespace GeneWinForms.Proxy
{
    public abstract class AbstractInterceptor : Castle.DynamicProxy.IInterceptor
    {
        public abstract InterceptorIdentity Id { get; }
        public virtual InterceptorProiority Priority { get { return InterceptorProiority.Default; } }
        public abstract void Intercept(Castle.DynamicProxy.IInvocation invocation);
    }
}
