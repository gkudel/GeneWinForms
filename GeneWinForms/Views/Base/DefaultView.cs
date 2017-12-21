using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GeneWinForms.Views.Base.Attributes;
using GeneWinForms.Views.Base.Resolver;

namespace GeneWinForms.Views.Base
{
    [View(ViewIdentity.UndefinedView)]
    public partial class DefaultView : XtraUserControl
    {
        public DefaultView()
        {
            InitializeComponent();
        }
    }
}
