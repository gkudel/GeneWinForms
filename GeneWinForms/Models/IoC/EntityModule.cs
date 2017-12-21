using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Castle.DynamicProxy;
using GeneWinForms.Proxy;
using Autofac.Core;
using GeneWinForms.Extensions;

namespace GeneWinForms.Models.IoC
{
    public class EntityModule : Module
    {
        private static readonly Lazy<ProxyGenerator> ProxyGenerator = new Lazy<ProxyGenerator>(() => new ProxyGenerator(new PersistentProxyBuilder()));

        private static readonly Lazy<ProxyGenerationOptions> ProxyOptions =
            new Lazy<ProxyGenerationOptions>(
                () =>
                    new ProxyGenerationOptions(new EntityInterceptorGenerationHook())
                    {
                        Selector = new EntityInterceptorSelector()
                    });

        protected override void Load(ContainerBuilder builder)
        {
            builder
                .Register((c, p) =>
                {
                    var parameters = p as Parameter[] ?? p.ToArray();
                    object dao = parameters.FirstOrDeftaultNamed<object>("dao");
                    ILifetimeScope scope = c.Resolve<ILifetimeScope>();
                    return (Order)
                        ProxyGenerator.Value.CreateClassProxy(typeof(Order), ProxyOptions.Value,
                        dao != null ? new[] { scope, dao } : new[] { scope },  
                        c.GetInterceptors(Entity.GetDescription<Order>().Interceptors));
                }).AsSelf();
            builder
                .Register((c, p) =>
                {
                    var parameters = p as Parameter[] ?? p.ToArray();
                    object dao = parameters.FirstOrDeftaultNamed<object>("dao");
                    return (Test)
                        ProxyGenerator.Value.CreateClassProxy(typeof(Test), ProxyOptions.Value,
                        dao != null ? new[] { dao } : null,
                        c.GetInterceptors(Entity.GetDescription<Test>().Interceptors));
                }).AsSelf();
            builder
                .Register((c, p) =>
                {
                    var parameters = p as Parameter[] ?? p.ToArray();
                    object dao = parameters.FirstOrDeftaultNamed<object>("dao");
                    return (Specimen)
                        ProxyGenerator.Value.CreateClassProxy(typeof(Specimen), ProxyOptions.Value,
                        dao != null ? new[] { dao } : null,
                        c.GetInterceptors(Entity.GetDescription<Specimen>().Interceptors));
                }).AsSelf();
        }
    }
}
