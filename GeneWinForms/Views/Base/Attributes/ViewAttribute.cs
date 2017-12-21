using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Utils.MVVM.UI;
using GeneWinForms.Views.Base.Resolver;

namespace GeneWinForms.Views.Base.Attributes
{
    public class ViewAttribute : ViewTypeAttribute
    {
        public ViewAttribute(ViewIdentity viewIdentity)
            : base(viewIdentity.ToString())
        { 
        }
    }
}
