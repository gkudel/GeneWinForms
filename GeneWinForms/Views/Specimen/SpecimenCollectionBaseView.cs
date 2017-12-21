using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneWinForms.Views.Test;
using GeneWinForms.Models.ViewModels.Order;
using entiy = GeneWinForms.Models;

namespace GeneWinForms.Views.Specimen
{
    public partial class SpecimenCollectionBaseView : CollectionView<OrderViewModel, entiy.Order, entiy.Specimen>
    {
        public SpecimenCollectionBaseView()
        {
            InitializeComponent();
        }
    }
}
