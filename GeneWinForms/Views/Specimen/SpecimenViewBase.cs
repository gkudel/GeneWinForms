using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneWinForms.Views.Base;
using entiy = GeneWinForms.Models;

namespace GeneWinForms.Views.Specimen
{
    public partial class SpecimenViewBase : SingleView<entiy.Specimen, long>
    {
        public SpecimenViewBase()
        {
            InitializeComponent();
        }
    }
}
