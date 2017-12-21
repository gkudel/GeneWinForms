using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneWinForms.Models.ViewModels.Order;
using entiy = GeneWinForms.Models;

namespace GeneWinForms.Views.Test
{
    public partial class TestCollectionBaseView : CollectionView<OrderViewModel, entiy.Order, entiy.Test>
    {
        public TestCollectionBaseView()
        {
            InitializeComponent();
        }
    }
}
