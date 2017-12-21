using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm;
using GeneWinForms.Proxy;

namespace GeneWinForms.Models.ViewModels.Base.Interfaces
{
    public interface IViewModel<TEntity> : ISupportParameter
        where TEntity : Entity
    {
        TEntity Entity { get; }
    }
}
