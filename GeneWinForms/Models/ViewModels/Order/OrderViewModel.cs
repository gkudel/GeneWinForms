using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Models.ViewModels.Test;
using entiy = GeneWinForms.Models;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm;
using GeneWinForms.Models.ViewModels.OrderHeader;
using GeneWinForms.Messages;
using DevExpress.Mvvm.DataAnnotations;
using GeneWinForms.Models.ViewModels.Base;
using GeneWinForms.Repositories;
using GeneWinForms.Dao;

namespace GeneWinForms.Models.ViewModels.Order
{
    [POCOViewModel]
    public class OrderViewModel : RepositoryViewModel<entiy.Order, long>
    {
        #region Constructor
        public OrderViewModel(IRepository<entiy.Order, long> orderRepository)
            : base(orderRepository)
        {
        }
        #endregion Constructor

        #region Command
        public void FormShown()
        {
            Messenger.Default.Send<OrderControlShowed>(new OrderControlShowed(Entity.OrderNumber));
        }
        #endregion Command
    }
}
