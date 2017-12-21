using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Proxy;
using System.ComponentModel;

namespace GeneWinForms.Repositories
{

    public interface IRepository<TEntity, TKey>
        where TEntity : Entity
    {
        TEntity Get(TKey key);        
    }

    public interface IRelatedRepository
    {
        object Get(object parent);
    }

    public interface IRelatedRepository<TParentEntity, TEntity> : IRelatedRepository       
        where TParentEntity : Entity
        where TEntity : Entity
    {
        IList<TEntity> Get(TParentEntity parent);
    }

}
