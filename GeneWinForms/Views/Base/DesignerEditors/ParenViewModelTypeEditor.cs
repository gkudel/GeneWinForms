using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Windows.Forms;
using GeneWinForms.Extensions;
using DevExpress.Mvvm.DataAnnotations;

namespace GeneWinForms.Views.Base.DesignerEditors
{
    public class ParenViewModelTypeEditor : UITypeEditor
    {
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (value != null && value.GetType() != typeof(string)) return value;
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                ListBox listBox = new ListBox();
                List<Item> dataSource = new List<Item>();
                dataSource.Add(new Item() { Name = string.Empty, Type = null });
                dataSource.AddRange(this.GetType().Assembly.GetTypes().Where(t => t.HasCustomAttribute<POCOViewModelAttribute>()).Select(t => new Item() { Type = t, Name = t.Name} ));
                listBox.DisplayMember = "Name";
                listBox.ValueMember = "Type";
                listBox.DataSource = dataSource;
                listBox.SelectedItem = value != null ? dataSource.FirstOrDefault(i => value.Equals(i.Type)) : null;
                listBox.SelectedValueChanged += new EventHandler((s, e) =>
                {
                    edSvc.CloseDropDown();
                });
                edSvc.DropDownControl(listBox);
                return listBox.SelectedItem != null ? ((Item)listBox.SelectedItem).Type : null;
            }
            return value;
        }

        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        private class Item
        {
            public Type Type { get; set; }
            public string Name { get; set; }
        }
    }
}
