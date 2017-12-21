using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Models.ViewModels.Base.Interfaces;
using GeneWinForms.Proxy;
using Autofac;

namespace GeneWinForms.Models.ViewModels.Base
{
    public class UnitOfWork<TEntity> : IUnitOfWork<TEntity> where TEntity : Entity
    {
        private ILifetimeScope lifeTimeScope;

        public UnitOfWork(ILifetimeScope lifeTimeScope)
        {
            this.lifeTimeScope = lifeTimeScope;
        }

        public TEntity Create()
        {
            return lifeTimeScope.Resolve<TEntity>();
        }
    }
}
