using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Castle.DynamicProxy;
using GeneWinForms.Proxy;
using Autofac.Core;
using GeneWinForms.Extensions;
using GeneWinForms.Models.ViewModels.Base;
using GeneWinForms.Models.ViewModels.Base.Interfaces;
using System.Reflection;
using DevExpress.Mvvm.DataAnnotations;
using GeneWinForms.Models.ViewModels.Test;
using GeneWinForms.Models.ViewModels.Specimen;
using DevExpress.Mvvm.POCO;
using entity = GeneWinForms.Models;
using GeneWinForms.Models.ViewModels.Order;
using GeneWinForms.Models.ViewModels.LazyControl;
using GeneWinForms.Models.ViewModels.OrderHeader;

namespace GeneWinForms.Models.ViewModels.IoC
{
    public class ViewModulesModule : Autofac.Module
    {        
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(UnitOfWork<>))
              .As(typeof(IUnitOfWork<>));

            foreach (var type in Assembly.GetExecutingAssembly().GetTypes().Where(t => t.HasCustomAttribute<POCOViewModelAttribute>()))
            {
                builder.RegisterType(ViewModelSource.GetPOCOType(type)).InstancePerDependency().As(type);
            }
        }
    }
}
