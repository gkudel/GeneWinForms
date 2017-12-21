using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Views.Base.Interfaces;
using DevExpress.Utils.MVVM.UI;
using DevExpress.Utils.MVVM.Services;

namespace GeneWinForms.Views.Base.Resolver
{
    public class ViewResolver : ViewServiceBase, IViewResolver
    {
        private ILazyControl lazyControl;
        public ViewResolver(ILazyControl lazyControl)
        {
            this.lazyControl = lazyControl;
        }

        public void Resolve()
        {
            lazyControl.AddControl(CreateAndInitializeView(lazyControl.ViewIdentity.ToString(), null, null, null));
        }

        public void Resolve(object parentViewModel)
        {
            lazyControl.AddControl(CreateAndInitializeView(lazyControl.ViewIdentity.ToString(), null, null, parentViewModel));
        }

        public void Resolve(object param, object parentViewModel)
        {
            lazyControl.AddControl(CreateAndInitializeView(lazyControl.ViewIdentity.ToString(), null, param, parentViewModel));
        }

        public bool ResolvingNeaded
        {
            get { return !lazyControl.IsResolved; }
        }
    }
}
