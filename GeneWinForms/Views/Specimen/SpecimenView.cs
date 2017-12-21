using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneWinForms.Views.Base.Attributes;
using GeneWinForms.Models.ViewModels.Specimen;

namespace GeneWinForms.Views.Specimen
{
    [View(Base.Resolver.ViewIdentity.SpecimenView)]
    public partial class SpecimenView : SpecimenViewBase
    {
        public SpecimenView()
        {
            InitializeComponent();
        }

        public override void InitBinding()
        {
            var fluantapi = mvvmContext.OfType<SpecimenViewModel>();
            fluantapi.SetBinding(txtCode, t => t.EditValue, m => m.Entity.Code);
            fluantapi.SetBinding(txtName, t => t.EditValue, m => m.Entity.Name);
        }
    }
}
