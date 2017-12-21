using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;

namespace GeneWinForms.Proxy.Interceptors.IoC
{
    public class InterceptorsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GetData>().As<AbstractInterceptor>()
                   .Keyed<AbstractInterceptor>(InterceptorIdentity.GetData)
                   .SingleInstance();

            builder.RegisterType<SetData>().As<AbstractInterceptor>()
                   .Keyed<AbstractInterceptor>(InterceptorIdentity.SetData)
                   .SingleInstance();

            builder.RegisterType<LazyLoading>().As<AbstractInterceptor>()
                   .Keyed<AbstractInterceptor>(InterceptorIdentity.LazyLoad)
                   .SingleInstance();
        }
    }
}
