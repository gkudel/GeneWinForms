using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneWinForms.Views.Base.Resolver;

namespace GeneWinForms.Views.Base.Interfaces
{
    public interface ILazyControl
    {
        ViewIdentity ViewIdentity { get; }
        bool IsResolved { get; }
        void AddControl(Control control);
    }
}
