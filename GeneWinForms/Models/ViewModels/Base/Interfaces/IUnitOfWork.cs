using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Proxy;

namespace GeneWinForms.Models.ViewModels.Base.Interfaces
{
    public interface IUnitOfWork<TEntity> where TEntity : Entity
    {
        TEntity Create();
    }
}
