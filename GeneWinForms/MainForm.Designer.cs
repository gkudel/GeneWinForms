namespace GeneWinForms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageEdit = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.testEditGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerTop = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dpTests = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.lazyTestCollection = new GeneWinForms.Views.Base.LazyControl();
            this.dpSpecimens = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.lazySpecimenCollection = new GeneWinForms.Views.Base.LazyControl();
            this.dpOrderHeader = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.lazyOrderHeader = new GeneWinForms.Views.Base.LazyControl();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerTop.SuspendLayout();
            this.panelContainer1.SuspendLayout();
            this.dpTests.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.dpSpecimens.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.dpOrderHeader.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnEdit,
            this.barButtonItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 4;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageEdit});
            this.ribbonControl.Size = new System.Drawing.Size(1166, 141);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPageEdit
            // 
            this.ribbonPageEdit.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.testEditGroup});
            this.ribbonPageEdit.Name = "ribbonPageEdit";
            this.ribbonPageEdit.Text = "Edit";
            // 
            // testEditGroup
            // 
            this.testEditGroup.ItemLinks.Add(this.btnEdit);
            this.testEditGroup.Name = "testEditGroup";
            this.testEditGroup.Text = "Edit";
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.ribbonControl;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // tabbedView
            // 
            this.tabbedView.RootContainer.Element = null;
            // 
            // dockManager
            // 
            this.dockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerTop});
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpOrderHeader});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // hideContainerTop
            // 
            this.hideContainerTop.BackColor = System.Drawing.SystemColors.Control;
            this.hideContainerTop.Controls.Add(this.panelContainer1);
            this.hideContainerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.hideContainerTop.Location = new System.Drawing.Point(0, 141);
            this.hideContainerTop.Name = "hideContainerTop";
            this.hideContainerTop.Size = new System.Drawing.Size(1166, 19);
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dpSpecimens;
            this.panelContainer1.Controls.Add(this.dpTests);
            this.panelContainer1.Controls.Add(this.dpSpecimens);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.panelContainer1.ID = new System.Guid("3f827a35-ad8e-4851-92ed-62a79319550f");
            this.panelContainer1.Location = new System.Drawing.Point(0, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.panelContainer1.SavedIndex = 0;
            this.panelContainer1.Size = new System.Drawing.Size(1166, 200);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            this.panelContainer1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dpTests
            // 
            this.dpTests.Controls.Add(this.dockPanel1_Container);
            this.dpTests.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dpTests.FloatVertical = true;
            this.dpTests.ID = new System.Guid("64b909be-55a1-4c55-9ac2-f4419261b79f");
            this.dpTests.Location = new System.Drawing.Point(4, 23);
            this.dpTests.Name = "dpTests";
            this.dpTests.OriginalSize = new System.Drawing.Size(1158, 172);
            this.dpTests.Size = new System.Drawing.Size(1158, 172);
            this.dpTests.Text = "Tests";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.lazyTestCollection);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1158, 172);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // lazyTestCollection
            // 
            this.lazyTestCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lazyTestCollection.Location = new System.Drawing.Point(0, 0);
            this.lazyTestCollection.Name = "lazyTestCollection";
            this.lazyTestCollection.ParenViewModelType = typeof(GeneWinForms.Models.ViewModels.Order.OrderViewModel);
            this.lazyTestCollection.Size = new System.Drawing.Size(1158, 172);
            this.lazyTestCollection.TabIndex = 0;
            this.lazyTestCollection.ViewIdentity = GeneWinForms.Views.Base.Resolver.ViewIdentity.TestsCollectionView;
            // 
            // dpSpecimens
            // 
            this.dpSpecimens.Controls.Add(this.dockPanel2_Container);
            this.dpSpecimens.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dpSpecimens.ID = new System.Guid("aa0c84b8-4ffc-4da0-80a1-9e4fd3e9ce79");
            this.dpSpecimens.Location = new System.Drawing.Point(4, 23);
            this.dpSpecimens.Name = "dpSpecimens";
            this.dpSpecimens.OriginalSize = new System.Drawing.Size(1158, 172);
            this.dpSpecimens.Size = new System.Drawing.Size(1158, 172);
            this.dpSpecimens.Text = "Specimens";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.lazySpecimenCollection);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(1158, 172);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // lazySpecimenCollection
            // 
            this.lazySpecimenCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lazySpecimenCollection.Location = new System.Drawing.Point(0, 0);
            this.lazySpecimenCollection.Name = "lazySpecimenCollection";
            this.lazySpecimenCollection.ParenViewModelType = typeof(GeneWinForms.Models.ViewModels.Order.OrderViewModel);
            this.lazySpecimenCollection.Size = new System.Drawing.Size(1158, 172);
            this.lazySpecimenCollection.TabIndex = 0;
            this.lazySpecimenCollection.ViewIdentity = GeneWinForms.Views.Base.Resolver.ViewIdentity.SepecimensCollectionView;
            // 
            // dpOrderHeader
            // 
            this.dpOrderHeader.Controls.Add(this.dockPanel3_Container);
            this.dpOrderHeader.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dpOrderHeader.ID = new System.Guid("17955622-52f2-4b9e-b98a-7f8d270b3622");
            this.dpOrderHeader.Location = new System.Drawing.Point(0, 160);
            this.dpOrderHeader.Name = "dpOrderHeader";
            this.dpOrderHeader.OriginalSize = new System.Drawing.Size(200, 73);
            this.dpOrderHeader.Size = new System.Drawing.Size(1166, 73);
            this.dpOrderHeader.Text = "Order Header";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.lazyOrderHeader);
            this.dockPanel3_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(1158, 45);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // lazyOrderHeader
            // 
            this.lazyOrderHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lazyOrderHeader.Location = new System.Drawing.Point(0, 0);
            this.lazyOrderHeader.Name = "lazyOrderHeader";
            this.lazyOrderHeader.ParenViewModelType = typeof(GeneWinForms.Models.ViewModels.Order.OrderViewModel);
            this.lazyOrderHeader.Size = new System.Drawing.Size(1158, 45);
            this.lazyOrderHeader.TabIndex = 0;
            this.lazyOrderHeader.ViewIdentity = GeneWinForms.Views.Base.Resolver.ViewIdentity.OrderHeaderView;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 655);
            this.Controls.Add(this.dpOrderHeader);
            this.Controls.Add(this.hideContainerTop);
            this.Controls.Add(this.ribbonControl);
            this.Name = "MainForm";
            this.Text = "Tests";
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerTop.ResumeLayout(false);
            this.panelContainer1.ResumeLayout(false);
            this.dpTests.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dpSpecimens.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.dpOrderHeader.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup testEditGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking.DockPanel dpOrderHeader;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dpTests;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dpSpecimens;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private GeneWinForms.Views.Base.LazyControl lazyTestCollection;
        private GeneWinForms.Views.Base.LazyControl lazyOrderHeader;
        private GeneWinForms.Views.Base.LazyControl lazySpecimenCollection;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerTop;
    }
}

