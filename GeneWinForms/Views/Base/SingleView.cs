using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneWinForms.Views.Base.Attributes;
using GeneWinForms.Views.Base.Resolver;
using DevExpress.XtraEditors;
using GeneWinForms.Models.ViewModels.Test;
using GeneWinForms.Views.Base.Interfaces;
using GeneWinForms.Proxy;
using GeneWinForms.Models.ViewModels.Base;

namespace GeneWinForms.Views.Base
{
    public partial class SingleView<TEntity, TKey> : XtraUserControl, IView where TEntity : Entity
    {
        public SingleView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode) InitBinding();
        }

        public virtual void InitBinding()
        {
            mvvmContext.SetTrigger<SingleEntityViewModel<TEntity, TKey>, TEntity>(m => m.Entity, e =>
            {
                EntiyChanged();
            });
        }

        public virtual void EntiyChanged()
        {
        }
    }
}
