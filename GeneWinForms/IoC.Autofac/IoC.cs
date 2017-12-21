using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using System.Reflection;
using Autofac.Core;
using GeneWinForms.Extensions;

namespace GeneWinForms.IoC.Autofac
{
    public static class IoC
    {
        private static ILifetimeScope _container;

        public static ILifetimeScope Container
        {
            get
            {
                return _container;
            }
        }

        public static void Configure(params Assembly[] assemblies)
        {
            if (_container != null) throw new InvalidOperationException("IoC already configured");

            var builder = new ContainerBuilder();
            List<Assembly> assembliesToAnalyze = new List<Assembly>(assemblies);
            if(!assembliesToAnalyze.Contains(typeof(IoC).Assembly)) assembliesToAnalyze.Add(typeof(IoC).Assembly);
            foreach (IModule instance in assembliesToAnalyze.SelectMany(assembly => assembly.GetTypes()
                .Where(x => x.AssignableTo<IModule>() && x.CanBeInstantiated())
                .Select(moduleType => Activator.CreateInstance(moduleType) as IModule)))
            {
                builder.RegisterModule(instance);
            }

            _container = builder.Build();
        }
    }
}
