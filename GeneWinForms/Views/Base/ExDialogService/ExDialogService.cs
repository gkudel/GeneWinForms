using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.MVVM.Services;

namespace GeneWinForms.Views.Base.ExDialogService
{
    public static class ExDialogService 
    {
        public static DevExpress.Utils.MVVM.Services.DialogService Create<TEntity>(IWin32Window owner)
        {
            return DevExpress.Utils.MVVM.Services.DialogService.Create(owner, "Edit " + typeof(TEntity).Name, new ProxyDialogFormFactory( new DevExpress.XtraBars.MVVM.Services.RibbonDialogFormFactory()));
        }
    }
}
