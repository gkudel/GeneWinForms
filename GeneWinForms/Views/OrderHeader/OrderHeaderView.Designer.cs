namespace GeneWinForms.Views
{
    partial class OrderHeaderControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblOrderNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderNumber = new DevExpress.XtraEditors.TextEdit();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.Location = new System.Drawing.Point(5, 10);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(36, 13);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order#";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(47, 7);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Properties.ReadOnly = true;
            this.txtOrderNumber.Size = new System.Drawing.Size(234, 20);
            this.txtOrderNumber.TabIndex = 1;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(GeneWinForms.Models.ViewModels.OrderHeader.OrderHeaderViewModel);
            // 
            // OrderHeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.lblOrderNumber);
            this.Name = "OrderHeaderControl";
            this.Size = new System.Drawing.Size(658, 35);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblOrderNumber;
        private DevExpress.XtraEditors.TextEdit txtOrderNumber;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
    }
}
