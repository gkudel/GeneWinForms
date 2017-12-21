using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.POCO;
using GeneWinForms.Views.Base;
using DevExpress.Mvvm;
using System.Windows.Forms;
using GeneWinForms.Messages;
using GeneWinForms.Views.Base.Interfaces;
using DevExpress.Utils.MVVM.UI;
using GeneWinForms.Models.ViewModels.Base;

namespace GeneWinForms.Models.ViewModels.LazyControl
{
    [POCOViewModel]
    public class LazyViewModel : AbstractParentViewModel
    {
        protected IViewResolver ViewResolver
        {
            get { return this.GetService<IViewResolver>(); }
        }

        public void LoadControl()
        {
            ViewResolver.Resolve(ParentViewModel);
        }

        public bool CanLoadControl()
        {
            return ViewResolver.ResolvingNeaded;
        }
    }
}
