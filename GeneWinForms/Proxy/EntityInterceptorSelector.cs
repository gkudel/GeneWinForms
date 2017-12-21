using System;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy;
using GeneWinForms.Proxy.Interceptors;

namespace GeneWinForms.Proxy
{
    public class EntityInterceptorSelector : IInterceptorSelector
    {
        #region IInterceptorSelector
        public Castle.DynamicProxy.IInterceptor[] SelectInterceptors(Type type, MethodInfo method, Castle.DynamicProxy.IInterceptor[] interceptors)
        {
            var interceptorIds = Entity.GetDescription(method.ReflectedType).Methods[method.ToString()].Interceptors;
            return interceptors.OfType<AbstractInterceptor>().Where(interceptor => interceptorIds.Contains(interceptor.Id)).OrderByDescending(a => a.Priority).Cast<Castle.DynamicProxy.IInterceptor>().ToArray();
        }
        #endregion IInterceptorSelector

        #region Equals & GetHashCode
        public override bool Equals(object obj)
        {
            return obj is EntityInterceptorSelector;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion Equals & GetHashCode

    }
}
