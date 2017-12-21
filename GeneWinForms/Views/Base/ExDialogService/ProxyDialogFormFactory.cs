using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Utils.MVVM.Services;
using GeneWinForms.Tools;
using GeneWinForms.Extensions;
using GeneWinForms.Views.Base.Interfaces;

namespace GeneWinForms.Views.Base.ExDialogService
{
    public class ProxyDialogFormFactory : IDialogFormFactory
    {

        private IDialogFormFactory baseFactory;
        public ProxyDialogFormFactory(IDialogFormFactory baseFactory)
        {
            Validator.IsNotNull<ArgumentNullException>(baseFactory, "baseFactory");
            this.baseFactory = baseFactory;
        }

        public IDialogForm Create()
        {
            return new ProxyDialogForm(baseFactory.Create());
        }

        private class ProxyDialogForm : IDialogForm
        {
            private IDialogForm dialogForm;
            public ProxyDialogForm(IDialogForm dialogForm)
            {
                this.dialogForm = dialogForm;
            }

            public void Close()
            {
                dialogForm.Close();
            }

            public event EventHandler Closed;

            public event System.ComponentModel.CancelEventHandler Closing;

            public System.Windows.Forms.Control Content
            {
                get { return dialogForm.Content; }
            }

            public System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.IWin32Window owner, System.Windows.Forms.Control content, string caption, System.Windows.Forms.DialogResult[] buttons)
            {
                content.Invoke<IView>(v => v.InitBinding());
                return dialogForm.ShowDialog(owner, content, caption, buttons);
            }

            public void Dispose()
            {
                dialogForm.Dispose();
                dialogForm = null;
            }
        }
    }
}
