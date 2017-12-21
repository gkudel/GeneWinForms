using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm;
using GeneWinForms.Proxy;

namespace GeneWinForms.Models.ViewModels.Base
{
    public abstract class SpecificParentViewModel<TViewModel> : ISupportParentViewModel
    {
        private TViewModel parentModel;
        public TViewModel ParentViewModel
        {
            get
            {
                return parentModel;
            }
        }

        object ISupportParentViewModel.ParentViewModel
        {
            get
            {
                return parentModel;
            }
            set
            {
                if (value != null)
                {
                    if (!typeof(TViewModel).IsAssignableFrom(value.GetType())) throw new InvalidCastException();
                    parentModel = (TViewModel)value;
                    OnParentViewModelChanged();
                }
                else 
                {
                    parentModel = default(TViewModel);
                    OnParentViewModelChanged();
                }
            }
        }

        protected virtual void OnParentViewModelChanged()
        {}
    }
}
