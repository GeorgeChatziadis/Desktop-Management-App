
namespace Jim.Forms
{
    partial class InventoryForm
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
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonRetrieve = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditMaterials = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditProducts = new DevExpress.XtraEditors.CheckEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityForOrders = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditMaterials.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditProducts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(BAL.Models.InventoryModel);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonRetrieve);
            this.panelControl1.Controls.Add(this.checkEditMaterials);
            this.panelControl1.Controls.Add(this.checkEditProducts);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(909, 49);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButtonRetrieve
            // 
            this.simpleButtonRetrieve.Location = new System.Drawing.Point(220, 10);
            this.simpleButtonRetrieve.Name = "simpleButtonRetrieve";
            this.simpleButtonRetrieve.Size = new System.Drawing.Size(111, 23);
            this.simpleButtonRetrieve.TabIndex = 2;
            this.simpleButtonRetrieve.Text = "Ανάκτηση";
            this.simpleButtonRetrieve.Click += new System.EventHandler(this.simpleButtonRetrieve_Click);
            // 
            // checkEditMaterials
            // 
            this.checkEditMaterials.Location = new System.Drawing.Point(117, 12);
            this.checkEditMaterials.Name = "checkEditMaterials";
            this.checkEditMaterials.Properties.Caption = "Υλικά";
            this.checkEditMaterials.Size = new System.Drawing.Size(75, 20);
            this.checkEditMaterials.TabIndex = 1;
            // 
            // checkEditProducts
            // 
            this.checkEditProducts.Location = new System.Drawing.Point(12, 12);
            this.checkEditProducts.Name = "checkEditProducts";
            this.checkEditProducts.Properties.Caption = "Προϊόντα";
            this.checkEditProducts.Size = new System.Drawing.Size(75, 20);
            this.checkEditProducts.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 49);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(909, 558);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colMaterialName,
            this.colQuantity,
            this.colQuantityForOrders,
            this.colBalance});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Προϊόν";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            // 
            // colMaterialName
            // 
            this.colMaterialName.Caption = "Υλικό";
            this.colMaterialName.FieldName = "MaterialName";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.OptionsColumn.AllowEdit = false;
            this.colMaterialName.OptionsColumn.ReadOnly = true;
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Ποσότητα";
            this.colQuantity.DisplayFormat.FormatString = "N2";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 91;
            // 
            // colQuantityForOrders
            // 
            this.colQuantityForOrders.Caption = "Ποσότητα για Παραγγελίες";
            this.colQuantityForOrders.DisplayFormat.FormatString = "N2";
            this.colQuantityForOrders.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityForOrders.FieldName = "QuantityForOrders";
            this.colQuantityForOrders.Name = "colQuantityForOrders";
            this.colQuantityForOrders.OptionsColumn.AllowEdit = false;
            this.colQuantityForOrders.OptionsColumn.ReadOnly = true;
            this.colQuantityForOrders.Visible = true;
            this.colQuantityForOrders.VisibleIndex = 3;
            this.colQuantityForOrders.Width = 142;
            // 
            // colBalance
            // 
            this.colBalance.Caption = "Ισοζύγιο";
            this.colBalance.DisplayFormat.FormatString = "N2";
            this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.OptionsColumn.AllowEdit = false;
            this.colBalance.OptionsColumn.ReadOnly = true;
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 4;
            this.colBalance.Width = 93;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 607);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "InventoryForm";
            this.Text = "Αποθήκη";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditMaterials.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditProducts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRetrieve;
        private DevExpress.XtraEditors.CheckEdit checkEditMaterials;
        private DevExpress.XtraEditors.CheckEdit checkEditProducts;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityForOrders;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
    }
}