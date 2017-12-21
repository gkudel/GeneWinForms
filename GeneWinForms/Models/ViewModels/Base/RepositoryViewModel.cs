using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm;
using GeneWinForms.Repositories;
using GeneWinForms.Tools;
using GeneWinForms.Proxy;
using GeneWinForms.Models.ViewModels.Base.Interfaces;

namespace GeneWinForms.Models.ViewModels.Base
{
    public abstract class RepositoryViewModel<TEntity, TParam> : IViewModel<TEntity>
        where TEntity : Entity
    {
        private IRepository<TEntity, TParam> repository;
        private Optional<TEntity> entity;

        public RepositoryViewModel(IRepository<TEntity, TParam> repository)
        {
            this.repository = repository;
        }

        public TEntity Entity
        {
            get 
            {
                if (entity == null)
                {
                    entity = Optional<TEntity>.Of(repository.Get(Param));
                }
                return entity.IsPresent() ? entity.Get() : default(TEntity);
            }
        }

        protected TParam param;
        public virtual TParam Param
        {
            get { return param; }
            set { param = value; }
        }

        public object Parameter
        {
            get
            {
                return Param;
            }
            set
            {
                if (value != null)
                {
                    if (!typeof(TParam).IsAssignableFrom(value.GetType())) throw new InvalidCastException();
                    Param = (TParam)value;
                }
                else
                {
                    Param = default(TParam);
                }
            }
        }
    }
}
