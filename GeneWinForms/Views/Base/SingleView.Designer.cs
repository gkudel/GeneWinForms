namespace GeneWinForms.Views.Base
{
    partial class SingleView<TEntity, TKey>
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
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpLayout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(GeneWinForms.Models.ViewModels.Test.TestViewModel);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnCustomize,
            this.btnSaveLayout,
            this.btnResetLayout});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 8;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.Size = new System.Drawing.Size(479, 141);
            // 
            // btnCustomize
            // 
            this.btnCustomize.Caption = "Customize";
            this.btnCustomize.Id = 5;
            this.btnCustomize.ImageOptions.ImageUri.Uri = "Customization;Size16x16";
            this.btnCustomize.Name = "btnCustomize";
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "Save Layout";
            this.btnSaveLayout.Id = 6;
            this.btnSaveLayout.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            this.btnSaveLayout.Name = "btnSaveLayout";
            // 
            // btnResetLayout
            // 
            this.btnResetLayout.Caption = "Reset Layout";
            this.btnResetLayout.Id = 7;
            this.btnResetLayout.ImageOptions.ImageUri.Uri = "Reset;Size16x16";
            this.btnResetLayout.Name = "btnResetLayout";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpLayout});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Test";
            // 
            // rbpLayout
            // 
            this.rbpLayout.ItemLinks.Add(this.btnCustomize);
            this.rbpLayout.ItemLinks.Add(this.btnSaveLayout);
            this.rbpLayout.ItemLinks.Add(this.btnResetLayout);
            this.rbpLayout.Name = "rbpLayout";
            this.rbpLayout.Text = "Layout";
            // 
            // layoutControl
            // 
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 141);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2441, 136, 450, 400);
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(479, 255);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(479, 255);
            this.layoutControlGroup.TextVisible = false;
            // 
            // SingleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "SingleView";
            this.Size = new System.Drawing.Size(479, 396);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraLayout.LayoutControl layoutControl;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        protected DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        protected DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpLayout;
        protected DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        protected DevExpress.XtraBars.BarButtonItem btnCustomize;
        protected DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        protected DevExpress.XtraBars.BarButtonItem btnResetLayout;
        protected DevExpress.Utils.MVVM.MVVMContext mvvmContext;
    }
}
