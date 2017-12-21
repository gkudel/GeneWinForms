using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneWinForms.Proxy;
using System.ComponentModel;
using System.Linq.Expressions;
using DevExpress.Mvvm.POCO;
using GeneWinForms.Models.ViewModels.Base.Interfaces;
using DevExpress.Mvvm;
using GeneWinForms.Extensions;
using GeneWinForms.Repositories;

namespace GeneWinForms.Models.ViewModels.Base
{
    public abstract class CollectionViewModel<TParentModelView, TParentEntity, TEntity> : SpecificParentViewModel<TParentModelView> 
        where TEntity : Entity
        where TParentEntity : Entity
        where TParentModelView : IViewModel<TParentEntity>
    {
        protected Lazy<IList<TEntity>> model;
        protected IUnitOfWork<TEntity> unitOfWork;

        public CollectionViewModel(Expression<Func<TParentEntity, IList<TEntity>>> childSelector, IUnitOfWork<TEntity> unitOfWork)
        {
            model = new Lazy<IList<TEntity>>(() =>
            {
                if (ParentViewModel == null) throw new InvalidOperationException("ParentViewModel can't be null");
                return childSelector.Compile()(ParentViewModel.Entity);
            });
            this.unitOfWork = unitOfWork;
        }

        public IList<TEntity> Model
        {
            get
            {
                return model.Value;
            }
        }
        
        protected IDialogService DialogService { get { return this.GetService<IDialogService>(); } }

        #region Selected Entity
        public virtual TEntity SelectedEntity { get; set; }
        protected void OnSelectedEntityChanged()
        {
            this.RaiseCanExecuteChanged(x => x.DeleteEntity());
            this.RaiseCanExecuteChanged(x => x.EditEntity());
        }
        #endregion Selected Entity

        #region Add New Entity
        protected virtual bool CanCreateNewEntity()
        {
            return true;
        }

        public void CreateNewEntity()
        {
            model.Value.Add(unitOfWork.Create());
        }
        #endregion Add New Entity

        #region Delete Entity
        public void DeleteEntity()
        {
            if (SelectedEntity == null) throw new InvalidOperationException();
            model.Value.Remove(SelectedEntity);
        }

        public virtual bool CanDeleteEntity()
        {
            return SelectedEntity != null;
        }
        #endregion Delete Entity
        
        #region Edit Entity
        public void EditEntity()
        {
            if (SelectedEntity == null) throw new InvalidOperationException();
            if (DialogService.ShowDialog(MessageButton.OKCancel, SelectedEntity, this) == MessageResult.OK)
            { }
        }

        public virtual bool CanEditEntity()
        {
            return SelectedEntity != null;
        }
        #endregion Edit Entity

    }
}
