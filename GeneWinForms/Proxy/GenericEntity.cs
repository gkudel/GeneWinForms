using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;

namespace GeneWinForms.Proxy
{
    public abstract class GenericEntity<TModel> : Entity
    {
        protected TModel model;

        public GenericEntity()
            : this(Activator.CreateInstance<TModel>())
        {            
        }

        public GenericEntity(TModel model)
            : base(model)
        {
            this.model = model;
        }

        public TModel Dao
        {
            get
            {
                return model;
            }
        }
    }
}
