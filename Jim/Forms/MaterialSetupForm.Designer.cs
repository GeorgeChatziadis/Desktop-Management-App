
namespace Jim.Forms
{
    partial class MaterialSetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialSetupForm));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDesignation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditMaterialCategories = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAddRecord = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaterialCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 24);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpEditMaterialCategories});
            this.gridControl.Size = new System.Drawing.Size(914, 625);
            this.gridControl.TabIndex = 0;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(BAL.Models.MaterialModel);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDesignation,
            this.colMaterialCategoryID});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            // 
            // colDesignation
            // 
            this.colDesignation.Caption = "Ονομασία";
            this.colDesignation.FieldName = "Designation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.Visible = true;
            this.colDesignation.VisibleIndex = 0;
            this.colDesignation.Width = 126;
            // 
            // colMaterialCategoryID
            // 
            this.colMaterialCategoryID.Caption = "Κατηγορία Υλικού";
            this.colMaterialCategoryID.ColumnEdit = this.lookUpEditMaterialCategories;
            this.colMaterialCategoryID.FieldName = "MaterialCategoryID";
            this.colMaterialCategoryID.Name = "colMaterialCategoryID";
            this.colMaterialCategoryID.Visible = true;
            this.colMaterialCategoryID.VisibleIndex = 1;
            this.colMaterialCategoryID.Width = 128;
            // 
            // lookUpEditMaterialCategories
            // 
            this.lookUpEditMaterialCategories.AutoHeight = false;
            this.lookUpEditMaterialCategories.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMaterialCategories.DataSource = this.bindingSource;
            this.lookUpEditMaterialCategories.KeyMember = "MaterialCategoryID";
            this.lookUpEditMaterialCategories.Name = "lookUpEditMaterialCategories";
            this.lookUpEditMaterialCategories.NullText = "";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonSave,
            this.barButtonAddRecord,
            this.barButtonDelete});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAddRecord, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDelete)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonSave
            // 
            this.barButtonSave.Caption = "Save";
            this.barButtonSave.Id = 0;
            this.barButtonSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonSave.ImageOptions.Image")));
            this.barButtonSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonSave.ImageOptions.LargeImage")));
            this.barButtonSave.Name = "barButtonSave";
            this.barButtonSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSave_ItemClick);
            // 
            // barButtonAddRecord
            // 
            this.barButtonAddRecord.Caption = "Add Record";
            this.barButtonAddRecord.Id = 1;
            this.barButtonAddRecord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonAddRecord.ImageOptions.Image")));
            this.barButtonAddRecord.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonAddRecord.ImageOptions.LargeImage")));
            this.barButtonAddRecord.Name = "barButtonAddRecord";
            this.barButtonAddRecord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAddRecord_ItemClick);
            // 
            // barButtonDelete
            // 
            this.barButtonDelete.Caption = "Delete";
            this.barButtonDelete.Id = 2;
            this.barButtonDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonDelete.ImageOptions.Image")));
            this.barButtonDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonDelete.ImageOptions.LargeImage")));
            this.barButtonDelete.Name = "barButtonDelete";
            this.barButtonDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(914, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 649);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(914, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 625);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(914, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 625);
            // 
            // MaterialSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 649);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MaterialSetupForm";
            this.Text = "Εισαγωγή Υλικών";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMaterialCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignation;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialCategoryID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditMaterialCategories;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonAddRecord;
        private DevExpress.XtraBars.BarButtonItem barButtonDelete;
    }
}