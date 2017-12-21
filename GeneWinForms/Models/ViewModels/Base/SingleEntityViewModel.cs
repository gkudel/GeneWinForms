using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Proxy;
using DevExpress.Mvvm;
using System.Linq.Expressions;
using DevExpress.Mvvm.DataAnnotations;

namespace GeneWinForms.Models.ViewModels.Base
{
    public class SingleEntityViewModel<TEntity, TKey> : ISupportParameter where TEntity : Entity
    {
        protected TEntity entity;
        private Func<TEntity, TKey> keySelector;

        public SingleEntityViewModel(Expression<Func<TEntity, TKey>> keySelector)
        {
            this.keySelector = keySelector.Compile();
        }

        public TKey Key
        {
            get { return keySelector(Entity); }
        }

        [BindableProperty]
        public virtual TEntity Entity
        {
            get { return entity; }
            set { entity = value; }
        }

        public object Parameter
        {
            get
            {
                return Entity;
            }
            set
            {
                if (value != null)
                {
                    if (!typeof(TEntity).IsAssignableFrom(value.GetType())) throw new InvalidCastException();
                    Entity = (TEntity)value;
                }
                else
                {
                    Entity = default(TEntity);
                }
            }
        }

        public void SaveLayout()
        { }
    }
}
