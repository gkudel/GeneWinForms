using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Proxy;

namespace GeneWinForms.Repositories.Impl
{
    public abstract class AbstractReletedRepository<TParentEntity, TEntity> : IRelatedRepository<TParentEntity, TEntity>
        where TParentEntity : Entity
        where TEntity : Entity
    {
        public virtual IList<TEntity> Get(TParentEntity parent)
        {
            throw new NotImplementedException();
        }

        object IRelatedRepository.Get(object parent)
        {
            return ((IRelatedRepository<TParentEntity, TEntity>)this).Get((TParentEntity)parent);
        }
    }
}
