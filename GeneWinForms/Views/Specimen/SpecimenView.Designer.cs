namespace GeneWinForms.Views.Specimen
{
    partial class SpecimenView
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
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lcCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lcName = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcName)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.txtCode);
            this.layoutControl.Controls.Add(this.txtName);
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2441, 136, 450, 400);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcCode,
            this.lcName});
            // 
            // btnCustomize
            // 
            this.btnCustomize.ImageOptions.ImageUri.Uri = "Customization;Size16x16";
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            // 
            // btnResetLayout
            // 
            this.btnResetLayout.ImageOptions.ImageUri.Uri = "Reset;Size16x16";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ViewModelType = typeof(GeneWinForms.Models.ViewModels.Specimen.SpecimenViewModel);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(43, 12);
            this.txtCode.MenuManager = this.ribbonControl;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(424, 20);
            this.txtCode.StyleController = this.layoutControl;
            this.txtCode.TabIndex = 4;
            // 
            // lcCode
            // 
            this.lcCode.Control = this.txtCode;
            this.lcCode.Location = new System.Drawing.Point(0, 0);
            this.lcCode.Name = "lcCode";
            this.lcCode.Size = new System.Drawing.Size(459, 24);
            this.lcCode.Text = "Code";
            this.lcCode.TextSize = new System.Drawing.Size(27, 13);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(43, 36);
            this.txtName.MenuManager = this.ribbonControl;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(424, 20);
            this.txtName.StyleController = this.layoutControl;
            this.txtName.TabIndex = 5;
            // 
            // lcName
            // 
            this.lcName.Control = this.txtName;
            this.lcName.Location = new System.Drawing.Point(0, 24);
            this.lcName.Name = "lcName";
            this.lcName.Size = new System.Drawing.Size(459, 211);
            this.lcName.Text = "Name";
            this.lcName.TextSize = new System.Drawing.Size(27, 13);
            // 
            // SpecimenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SpecimenView";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem lcCode;
        private DevExpress.XtraLayout.LayoutControlItem lcName;
    }
}
