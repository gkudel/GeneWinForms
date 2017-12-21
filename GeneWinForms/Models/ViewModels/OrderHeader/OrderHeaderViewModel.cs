using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using entiy = GeneWinForms.Models;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using GeneWinForms.Models.ViewModels.Order;
using GeneWinForms.Models.ViewModels.Base;

namespace GeneWinForms.Models.ViewModels.OrderHeader
{
    [POCOViewModel]
    public class OrderHeaderViewModel : SpecificParentViewModel<OrderViewModel>
    {
        public entiy.Order Order 
        {
            get
            {
                return ParentViewModel.Entity;
            }
        }
    }
}
