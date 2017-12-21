using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneWinForms.Views.Base;
using GeneWinForms.Views.Base.Attributes;
using GeneWinForms.Models.ViewModels.Test;

namespace GeneWinForms.Views.Test
{
    [View(Base.Resolver.ViewIdentity.TestView)]
    public partial class TestView : TestViewBase
    {
        public TestView()
        {
            InitializeComponent();
        }

        public override void EntiyChanged()
        {
            var fluantapi = mvvmContext.OfType<TestViewModel>();
            fluantapi.SetBinding(txtCode, t => t.EditValue, m => m.Entity.Code);
            fluantapi.SetBinding(txtName, t => t.EditValue, m => m.Entity.Name);
        }
    }
}
