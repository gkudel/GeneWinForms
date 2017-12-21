using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using GeneWinForms.Proxy.Interceptors;
using GeneWinForms.Proxy;

namespace GeneWinForms.Extensions
{
    public static class ComponentContextExtensions
    {
        public static Castle.DynamicProxy.IInterceptor[] GetInterceptors(this IComponentContext context, InterceptorIdentity[] ids)
        {
            var interceptors = new List<AbstractInterceptor>();
            foreach (var interceptorsList in ids.Select(id => context.ResolveKeyed<IEnumerable<Proxy.AbstractInterceptor>>(id).ToList()))
            {
                if (interceptorsList.Count == 1)
                {
                    interceptors.Add(interceptorsList[0]);
                }
                else if (interceptorsList.Count == 0)
                {
                    throw new InvalidOperationException("no Interceptor registered for id ");
                }
                else
                {
                    throw new InvalidOperationException(
                        "too many interceptors registered for id , only one intercpetor is allowed");
                }
            }
            return interceptors.ToArray();
        }
    }
}
