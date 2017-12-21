using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using GeneWinForms.Views.Base.Resolver;

namespace GeneWinForms.Views.Base.DesignerEditors
{
    public class ViewIdentityEditor : UITypeEditor
    {
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (value != null && value.GetType() != typeof(ViewIdentity)) return value;
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                ListBox listBox = new ListBox();
                List<string> dataSource = new List<string>();
                dataSource.AddRange(Enum.GetNames(typeof(ViewIdentity)));
                listBox.DataSource = dataSource;
                listBox.SelectedItem = value != null ? (ViewIdentity)value : ViewIdentity.UndefinedView;
                listBox.SelectedValueChanged += new EventHandler((s, e) =>
                {
                    edSvc.CloseDropDown();
                });
                edSvc.DropDownControl(listBox);
                return listBox.SelectedItem != null ? Enum.Parse(typeof(ViewIdentity), listBox.SelectedItem.ToString()) : ViewIdentity.UndefinedView;
            }
            return value;
        }

        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }
    }
}
