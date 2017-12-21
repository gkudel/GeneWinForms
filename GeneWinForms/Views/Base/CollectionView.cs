using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GeneWinForms.Extensions;
using DevExpress.XtraGrid.Views.Base;
using GeneWinForms.Models;
using GeneWinForms.Models.ViewModels.Order;
using GeneWinForms.Models.ViewModels.Test;
using entity = GeneWinForms.Models;
using GeneWinForms.Views.Base.Attributes;
using GeneWinForms.Views.Base.Resolver;
using GeneWinForms.Views.Base.Interfaces;
using GeneWinForms.Views.Base;
using GeneWinForms.Models.ViewModels.Base;
using GeneWinForms.Proxy;
using DevExpress.Utils.MVVM.Services;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;
using GeneWinForms.Models.ViewModels.Base.Interfaces;

namespace GeneWinForms.Views.Test
{
    public partial class CollectionView<TParentModelView, TParentEntity,TEntity> : XtraUserControl, IView
        where TEntity : Entity
        where TParentEntity : Entity
        where TParentModelView : IViewModel<TParentEntity>
    {
        public CollectionView()
        {
            InitializeComponent();
        }

        public virtual void InitBinding()
        {
            mvvmContext.RegisterService(DialogService.Create(this, DefaultDialogServiceType.RibbonDialog, "Eidt " + typeof(TEntity).Name));
            var fluantapi = mvvmContext.OfType<CollectionViewModel<TParentModelView, TParentEntity, TEntity>>();
            fluantapi.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridMainView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as TEntity, (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            fluantapi.SetBinding(gridControl, t => t.DataSource, m => m.Model);
            fluantapi.BindCommand(btnNew, m => m.CreateNewEntity());
            fluantapi.BindCommand(btnDelete, m => m.DeleteEntity());
            fluantapi.BindCommand(btnEdit, m => m.EditEntity());
        }
    }
}
