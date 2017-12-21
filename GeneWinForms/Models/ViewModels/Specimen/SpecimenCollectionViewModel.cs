using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using entiy = GeneWinForms.Models;
using System.ComponentModel;
using GeneWinForms.Proxy;
using GeneWinForms.Dao;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using GeneWinForms.Models.ViewModels.Order;
using GeneWinForms.Models.ViewModels.Base;
using GeneWinForms.Models.ViewModels.Base.Interfaces;
using GeneWinForms.Repositories;

namespace GeneWinForms.Models.ViewModels.Specimen
{
    [POCOViewModel]
    public class SpecimenCollectionViewModel : CollectionViewModel<OrderViewModel, entiy.Order, entiy.Specimen>
    {
        public SpecimenCollectionViewModel(IUnitOfWork<entiy.Specimen> unitOfWork)
            : base(o => o.Specimens, unitOfWork)
        {
        }
    }
}
