using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Mvvm.UI;
using DevExpress.Utils.MVVM.UI;

namespace GeneWinForms.Views.Base.Interfaces
{
    public interface IViewResolver
    {
        void Resolve();
        void Resolve(object parentViewModel);
        void Resolve(object param, object parentViewModel);
        bool ResolvingNeaded { get; }
    }
}
