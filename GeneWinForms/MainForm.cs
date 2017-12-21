using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeneWinForms.Dao;
using DevExpress.Mvvm;
using GeneWinForms.Messages;
using GeneWinForms.Proxy;
using DevExpress.Utils.MVVM.Services;
using GeneWinForms.Models.ViewModels.Order;
using GeneWinForms.Views.Base;
using GeneWinForms.Models;
using Autofac;
using GeneWinForms.IoC.Autofac;
using DevExpress.Utils.MVVM;
using System.Reflection;

namespace GeneWinForms
{
    public partial class MainForm : Form
    {
        private ILifetimeScope _scope;
        public MainForm()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode) InitBinding();
        }

        private void InitBinding()
        {
            IoC.Autofac.IoC.Configure(Assembly.GetCallingAssembly());
            _scope = IoC.Autofac.IoC.Container.BeginLifetimeScope();
            MVVMContextCompositionRoot.ViewModelCreate += new ViewModelCreateEventHandler(MVVMContextCompositionRoot_ViewModelCreate);
            mvvmContext.ViewModelType = typeof(OrderViewModel);
            mvvmContext.Parameter = 1024L;
            var fluentApi = mvvmContext.OfType<OrderViewModel>();
            fluentApi.EventToCommand<EventArgs>(this, "Shown", m => m.FormShown());
        }

        void MVVMContextCompositionRoot_ViewModelCreate(object sender, ViewModelCreateEventArgs e)
        {
            e.ViewModel = _scope.Resolve(e.ViewModelType);
        }
    }
}
