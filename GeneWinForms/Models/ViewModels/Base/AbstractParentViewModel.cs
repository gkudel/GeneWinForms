using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm;

namespace GeneWinForms.Models.ViewModels.Base
{
    public class AbstractParentViewModel : ISupportParentViewModel
    {
        public virtual object ParentViewModel { get; set; }
    }
}
