using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GeneWinForms.Extensions;
using GeneWinForms.Models.ViewModels.Order;
using GeneWinForms.Models.ViewModels.OrderHeader;
using GeneWinForms.Views.Base.Attributes;
using GeneWinForms.Views.Base.Resolver;
using GeneWinForms.Views.Base.Interfaces;

namespace GeneWinForms.Views
{
    [View(ViewIdentity.OrderHeaderView)]
    public partial class OrderHeaderControl : XtraUserControl, IView
    {
        public OrderHeaderControl()
        {
            InitializeComponent();
        }

        public void InitBinding()
        {
            var fluantapi = mvvmContext.OfType<OrderHeaderViewModel>();
            fluantapi.SetBinding(txtOrderNumber, t => t.EditValue, m => m.Order.OrderNumber);
        }
    }
}
