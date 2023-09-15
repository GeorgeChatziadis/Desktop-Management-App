
namespace Jim.Forms
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpEditTown = new DevExpress.XtraEditors.LookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonNewOrder = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bindingSourceTowns = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButtonRetrieve = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditIsDone = new DevExpress.XtraEditors.CheckEdit();
            this.labelControlIsDone = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditClient = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceClientLookUp = new System.Windows.Forms.BindingSource(this.components);
            this.labelControlClient = new DevExpress.XtraEditors.LabelControl();
            this.dateEditTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControlDateTo = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDateFrom = new DevExpress.XtraEditors.LabelControl();
            this.dateEditFrom = new DevExpress.XtraEditors.DateEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDesignation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeSpent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualProfit = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTowns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsDone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClientLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lookUpEditTown);
            this.splitContainer1.Panel1.Controls.Add(this.simpleButtonRetrieve);
            this.splitContainer1.Panel1.Controls.Add(this.checkEditIsDone);
            this.splitContainer1.Panel1.Controls.Add(this.labelControlIsDone);
            this.splitContainer1.Panel1.Controls.Add(this.lookUpEditClient);
            this.splitContainer1.Panel1.Controls.Add(this.labelControlClient);
            this.splitContainer1.Panel1.Controls.Add(this.dateEditTo);
            this.splitContainer1.Panel1.Controls.Add(this.labelControlDateTo);
            this.splitContainer1.Panel1.Controls.Add(this.labelControlDateFrom);
            this.splitContainer1.Panel1.Controls.Add(this.dateEditFrom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl);
            this.splitContainer1.Size = new System.Drawing.Size(1212, 582);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(407, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Πόλη";
            // 
            // lookUpEditTown
            // 
            this.lookUpEditTown.Location = new System.Drawing.Point(449, 8);
            this.lookUpEditTown.MenuManager = this.barManager1;
            this.lookUpEditTown.Name = "lookUpEditTown";
            this.lookUpEditTown.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTown.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Designation", "Ονομασία", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditTown.Properties.DataSource = this.bindingSourceTowns;
            this.lookUpEditTown.Properties.DisplayMember = "Designation";
            this.lookUpEditTown.Properties.NullText = "";
            this.lookUpEditTown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditTown.Properties.ValueMember = "ID";
            this.lookUpEditTown.Size = new System.Drawing.Size(119, 20);
            this.lookUpEditTown.TabIndex = 11;
            this.lookUpEditTown.EditValueChanged += new System.EventHandler(this.lookUpEditTown_EditValueChanged);
            this.lookUpEditTown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookUpEditTown_KeyDown);
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
            this.barButtonNewOrder});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonNewOrder)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonNewOrder
            // 
            this.barButtonNewOrder.Caption = "Νέα Παραγγελία";
            this.barButtonNewOrder.Id = 0;
            this.barButtonNewOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonNewOrder.ImageOptions.Image")));
            this.barButtonNewOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonNewOrder.ImageOptions.LargeImage")));
            this.barButtonNewOrder.Name = "barButtonNewOrder";
            this.barButtonNewOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNewOrder_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1212, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 606);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1212, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 582);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1212, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 582);
            // 
            // bindingSourceTowns
            // 
            this.bindingSourceTowns.DataSource = typeof(BAL.Models.LookUpEditModel);
            // 
            // simpleButtonRetrieve
            // 
            this.simpleButtonRetrieve.Location = new System.Drawing.Point(1037, 6);
            this.simpleButtonRetrieve.Name = "simpleButtonRetrieve";
            this.simpleButtonRetrieve.Size = new System.Drawing.Size(98, 23);
            this.simpleButtonRetrieve.TabIndex = 10;
            this.simpleButtonRetrieve.Text = "Ανάκτηση";
            this.simpleButtonRetrieve.Click += new System.EventHandler(this.simpleButtonRetrieve_Click);
            // 
            // checkEditIsDone
            // 
            this.checkEditIsDone.Location = new System.Drawing.Point(955, 8);
            this.checkEditIsDone.MenuManager = this.barManager1;
            this.checkEditIsDone.Name = "checkEditIsDone";
            this.checkEditIsDone.Properties.Caption = "";
            this.checkEditIsDone.Size = new System.Drawing.Size(75, 20);
            this.checkEditIsDone.TabIndex = 9;
            this.checkEditIsDone.CheckedChanged += new System.EventHandler(this.checkEditIsDone_CheckedChanged);
            // 
            // labelControlIsDone
            // 
            this.labelControlIsDone.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControlIsDone.Appearance.Options.UseFont = true;
            this.labelControlIsDone.Location = new System.Drawing.Point(848, 11);
            this.labelControlIsDone.Name = "labelControlIsDone";
            this.labelControlIsDone.Size = new System.Drawing.Size(101, 13);
            this.labelControlIsDone.TabIndex = 8;
            this.labelControlIsDone.Text = "Έχει Ολοκληρωθεί";
            // 
            // lookUpEditClient
            // 
            this.lookUpEditClient.Location = new System.Drawing.Point(648, 9);
            this.lookUpEditClient.MenuManager = this.barManager1;
            this.lookUpEditClient.Name = "lookUpEditClient";
            this.lookUpEditClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditClient.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Designation", "Όνομα", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditClient.Properties.DataSource = this.bindingSourceClientLookUp;
            this.lookUpEditClient.Properties.DisplayMember = "Designation";
            this.lookUpEditClient.Properties.NullText = "";
            this.lookUpEditClient.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditClient.Properties.ValueMember = "ID";
            this.lookUpEditClient.Size = new System.Drawing.Size(176, 20);
            this.lookUpEditClient.TabIndex = 7;
            this.lookUpEditClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookUpEditClient_KeyDown);
            // 
            // bindingSourceClientLookUp
            // 
            this.bindingSourceClientLookUp.DataSource = typeof(BAL.Models.LookUpEditModel);
            // 
            // labelControlClient
            // 
            this.labelControlClient.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControlClient.Appearance.Options.UseFont = true;
            this.labelControlClient.Location = new System.Drawing.Point(593, 12);
            this.labelControlClient.Name = "labelControlClient";
            this.labelControlClient.Size = new System.Drawing.Size(49, 13);
            this.labelControlClient.TabIndex = 6;
            this.labelControlClient.Text = "Πελάτης";
            // 
            // dateEditTo
            // 
            this.dateEditTo.EditValue = null;
            this.dateEditTo.Location = new System.Drawing.Point(281, 8);
            this.dateEditTo.MenuManager = this.barManager1;
            this.dateEditTo.Name = "dateEditTo";
            this.dateEditTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTo.Size = new System.Drawing.Size(100, 20);
            this.dateEditTo.TabIndex = 3;
            // 
            // labelControlDateTo
            // 
            this.labelControlDateTo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControlDateTo.Appearance.Options.UseFont = true;
            this.labelControlDateTo.Location = new System.Drawing.Point(210, 11);
            this.labelControlDateTo.Name = "labelControlDateTo";
            this.labelControlDateTo.Size = new System.Drawing.Size(65, 13);
            this.labelControlDateTo.TabIndex = 2;
            this.labelControlDateTo.Text = "Ημ/νία Έως";
            // 
            // labelControlDateFrom
            // 
            this.labelControlDateFrom.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControlDateFrom.Appearance.Options.UseFont = true;
            this.labelControlDateFrom.Location = new System.Drawing.Point(16, 11);
            this.labelControlDateFrom.Name = "labelControlDateFrom";
            this.labelControlDateFrom.Size = new System.Drawing.Size(63, 13);
            this.labelControlDateFrom.TabIndex = 1;
            this.labelControlDateFrom.Text = "Ημ/νία Από";
            // 
            // dateEditFrom
            // 
            this.dateEditFrom.EditValue = null;
            this.dateEditFrom.Location = new System.Drawing.Point(85, 8);
            this.dateEditFrom.MenuManager = this.barManager1;
            this.dateEditFrom.Name = "dateEditFrom";
            this.dateEditFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Size = new System.Drawing.Size(100, 20);
            this.dateEditFrom.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1212, 517);
            this.gridControl.TabIndex = 0;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(BAL.Models.OrderModel);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDesignation,
            this.colDate,
            this.colProfit,
            this.colTimeSpent,
            this.colDueDate,
            this.colClient,
            this.colIsDone,
            this.colIsPaid,
            this.colActualProfit});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // colDesignation
            // 
            this.colDesignation.Caption = "Σχόλια";
            this.colDesignation.FieldName = "Comments";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.OptionsColumn.AllowEdit = false;
            this.colDesignation.OptionsColumn.ReadOnly = true;
            this.colDesignation.Visible = true;
            this.colDesignation.VisibleIndex = 8;
            this.colDesignation.Width = 135;
            // 
            // colDate
            // 
            this.colDate.Caption = "Ημερομηνία";
            this.colDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.OptionsColumn.ReadOnly = true;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 90;
            // 
            // colProfit
            // 
            this.colProfit.Caption = "Τιμή Παραγγελίας";
            this.colProfit.DisplayFormat.FormatString = "N2";
            this.colProfit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colProfit.FieldName = "Profit";
            this.colProfit.Name = "colProfit";
            this.colProfit.OptionsColumn.AllowEdit = false;
            this.colProfit.OptionsColumn.ReadOnly = true;
            this.colProfit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Profit", "{0:N2}")});
            this.colProfit.Visible = true;
            this.colProfit.VisibleIndex = 2;
            this.colProfit.Width = 100;
            // 
            // colTimeSpent
            // 
            this.colTimeSpent.Caption = "Χρόνος ";
            this.colTimeSpent.DisplayFormat.FormatString = "N1";
            this.colTimeSpent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTimeSpent.FieldName = "TimeSpent";
            this.colTimeSpent.Name = "colTimeSpent";
            this.colTimeSpent.OptionsColumn.AllowEdit = false;
            this.colTimeSpent.OptionsColumn.ReadOnly = true;
            this.colTimeSpent.Visible = true;
            this.colTimeSpent.VisibleIndex = 7;
            this.colTimeSpent.Width = 87;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "Ημ/νία Παράδοσης";
            this.colDueDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.OptionsColumn.AllowEdit = false;
            this.colDueDate.OptionsColumn.ReadOnly = true;
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 4;
            this.colDueDate.Width = 110;
            // 
            // colClient
            // 
            this.colClient.Caption = "Πελάτης";
            this.colClient.FieldName = "ClientName";
            this.colClient.Name = "colClient";
            this.colClient.OptionsColumn.AllowEdit = false;
            this.colClient.OptionsColumn.ReadOnly = true;
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 1;
            this.colClient.Width = 177;
            // 
            // colIsDone
            // 
            this.colIsDone.Caption = "Ολοκληρώθηκε";
            this.colIsDone.FieldName = "IsDone";
            this.colIsDone.Name = "colIsDone";
            this.colIsDone.OptionsColumn.AllowEdit = false;
            this.colIsDone.OptionsColumn.ReadOnly = true;
            this.colIsDone.Visible = true;
            this.colIsDone.VisibleIndex = 5;
            this.colIsDone.Width = 86;
            // 
            // colIsPaid
            // 
            this.colIsPaid.Caption = "Πληρώθηκε";
            this.colIsPaid.FieldName = "IsPaid";
            this.colIsPaid.Name = "colIsPaid";
            this.colIsPaid.OptionsColumn.AllowEdit = false;
            this.colIsPaid.OptionsColumn.ReadOnly = true;
            this.colIsPaid.Visible = true;
            this.colIsPaid.VisibleIndex = 6;
            this.colIsPaid.Width = 81;
            // 
            // colActualProfit
            // 
            this.colActualProfit.Caption = "Καθαρό Κέρδος";
            this.colActualProfit.DisplayFormat.FormatString = "N2";
            this.colActualProfit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colActualProfit.FieldName = "ActualProfit";
            this.colActualProfit.Name = "colActualProfit";
            this.colActualProfit.OptionsColumn.AllowEdit = false;
            this.colActualProfit.OptionsColumn.ReadOnly = true;
            this.colActualProfit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ActualProfit", "{0:N2}")});
            this.colActualProfit.Visible = true;
            this.colActualProfit.VisibleIndex = 3;
            this.colActualProfit.Width = 93;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 606);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "OrdersForm";
            this.Text = "Παραγγελίες";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTowns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsDone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClientLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.DateEdit dateEditTo;
        private DevExpress.XtraEditors.LabelControl labelControlDateTo;
        private DevExpress.XtraEditors.LabelControl labelControlDateFrom;
        private DevExpress.XtraEditors.DateEdit dateEditFrom;
        private DevExpress.XtraEditors.CheckEdit checkEditIsDone;
        private DevExpress.XtraEditors.LabelControl labelControlIsDone;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditClient;
        private DevExpress.XtraEditors.LabelControl labelControlClient;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRetrieve;
        private DevExpress.XtraBars.BarButtonItem barButtonNewOrder;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignation;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProfit;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeSpent;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDone;
        private System.Windows.Forms.BindingSource bindingSourceClientLookUp;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colActualProfit;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTown;
        private System.Windows.Forms.BindingSource bindingSourceTowns;
    }
}