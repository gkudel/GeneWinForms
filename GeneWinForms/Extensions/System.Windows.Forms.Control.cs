using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;

namespace GeneWinForms.Extensions
{
    public static class ControlExtensions
    {
        public static T GetViewModel<T>(this Control @this)
        {
            object viewModel = GetViewModel(@this, typeof(T));
            if (viewModel != null) return (T)viewModel;
            return default(T);
        }

        public static object GetViewModel(this Control @this, Type type)
        {
            if (@this != null)
            {
                MVVMContext context = MVVMContext.FromControl(@this);
                if (context != null && context.ViewModelType == type)
                {
                    return MVVMContext.GetViewModel(@this);
                }
                var dockPanel = @this as DockPanel;
                if(dockPanel != null)
                {
                    return GetViewModel(dockPanel.DockManager.Form, type);
                }
                if (@this.Parent != null)
                {
                    return GetViewModel(@this.Parent, type);
                }
            }
            return null;
        }
    }
}
