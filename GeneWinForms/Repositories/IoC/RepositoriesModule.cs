using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using GeneWinForms.Repositories.Impl;
using GeneWinForms.Models;

namespace GeneWinForms.Repositories.IoC
{
    public class RepositoriesModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OrderRepository>().As<IRepository<Order, long>>();
            builder.RegisterType<TestRepository>().As<IRelatedRepository<Order, Test>>();
            builder.RegisterType<SpecimenRepository>().As<IRelatedRepository<Order, Specimen>>();
        }
    }
}
