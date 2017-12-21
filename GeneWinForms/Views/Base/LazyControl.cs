using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Mvvm;
using GeneWinForms.Messages;
using System.Drawing.Design;
using GeneWinForms.Models.ViewModels.LazyControl;
using GeneWinForms.Views.Base.Resolver;
using GeneWinForms.Views.Base.Interfaces;
using GeneWinForms.Models.ViewModels.Order;
using GeneWinForms.Extensions;
using GeneWinForms.Views.Base.DesignerEditors;

namespace GeneWinForms.Views.Base
{
    public partial class LazyControl : XtraUserControl, ILazyControl
    {

        #region Constructor
        public LazyControl()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode) Messenger.Default.Register<OrderControlShowed>(this, s => OnShowed(s));
        }
        #endregion Constructor

        #region Properties
        [Editor(typeof(ViewIdentityEditor), typeof(UITypeEditor))]
        public ViewIdentity ViewIdentity { get; set; }

        [Editor(typeof(ParenViewModelTypeEditor), typeof(UITypeEditor))]
        public Type ParenViewModelType { get; set;}
        #endregion Properties

        private void InitializeBindings(object parentViewModel)
        {
            mvvmContext.ParentViewModel = parentViewModel;
            mvvmContext.RegisterService(new ViewResolver(this));            
        }

        private void OnShowed(OrderControlShowed showed)
        {
            object parentViewModel = null;
            if (ParenViewModelType != null) parentViewModel = this.GetViewModel(ParenViewModelType);
            InitializeBindings(parentViewModel);
            if (!Visible)
            {
                var fluent = mvvmContext.OfType<LazyViewModel>();
                fluent.WithEvent<EventArgs>(this, "VisibleChanged").EventToCommand(x => x.LoadControl());
            }
            else 
            {
                mvvmContext.GetViewModel<LazyViewModel>().LoadControl();
            }
        }

        public void AddControl(Control control)
        {
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
            control.Invoke<IView>(v => v.InitBinding());
        }

        public bool IsResolved
        {
            get { return this.Controls.Count > 0;  }
        }
    }
}
