
namespace Jim.Modals
{
    partial class ClientSetupModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientSetupModal));
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.lookUpEditTown = new DevExpress.XtraEditors.LookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEditComments = new DevExpress.XtraEditors.TextEdit();
            this.textEditEmail = new DevExpress.XtraEditors.TextEdit();
            this.textEditMobile = new DevExpress.XtraEditors.TextEdit();
            this.textEditTelephone = new DevExpress.XtraEditors.TextEdit();
            this.textEditAddress = new DevExpress.XtraEditors.TextEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlTelephone = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlMobilePhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlComments = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditComments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTelephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMobilePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.dataLayoutControl1);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 24);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(385, 223);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.lookUpEditTown);
            this.dataLayoutControl1.Controls.Add(this.textEditComments);
            this.dataLayoutControl1.Controls.Add(this.textEditEmail);
            this.dataLayoutControl1.Controls.Add(this.textEditMobile);
            this.dataLayoutControl1.Controls.Add(this.textEditTelephone);
            this.dataLayoutControl1.Controls.Add(this.textEditAddress);
            this.dataLayoutControl1.Controls.Add(this.textEditName);
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 12);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(361, 199);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // lookUpEditTown
            // 
            this.lookUpEditTown.Location = new System.Drawing.Point(95, 36);
            this.lookUpEditTown.MenuManager = this.barManager1;
            this.lookUpEditTown.Name = "lookUpEditTown";
            this.lookUpEditTown.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTown.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Designation", "Όνομα", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.True)});
            this.lookUpEditTown.Properties.DataSource = this.bindingSource;
            this.lookUpEditTown.Properties.DisplayMember = "Designation";
            this.lookUpEditTown.Properties.NullText = "";
            this.lookUpEditTown.Properties.ValueMember = "ID";
            this.lookUpEditTown.Size = new System.Drawing.Size(254, 20);
            this.lookUpEditTown.StyleController = this.dataLayoutControl1;
            this.lookUpEditTown.TabIndex = 10;
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
            this.barButtonDelete});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonDelete)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonSave
            // 
            this.barButtonSave.Caption = "Αποθήκευση";
            this.barButtonSave.Id = 0;
            this.barButtonSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonSave.ImageOptions.Image")));
            this.barButtonSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonSave.ImageOptions.LargeImage")));
            this.barButtonSave.Name = "barButtonSave";
            this.barButtonSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSave_ItemClick);
            // 
            // barButtonDelete
            // 
            this.barButtonDelete.Caption = "Διαγραφή";
            this.barButtonDelete.Enabled = false;
            this.barButtonDelete.Id = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(385, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 247);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(385, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 223);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(385, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 223);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(BAL.Models.LookUpEditModel);
            // 
            // textEditComments
            // 
            this.textEditComments.Location = new System.Drawing.Point(95, 156);
            this.textEditComments.MenuManager = this.barManager1;
            this.textEditComments.Name = "textEditComments";
            this.textEditComments.Size = new System.Drawing.Size(254, 20);
            this.textEditComments.StyleController = this.dataLayoutControl1;
            this.textEditComments.TabIndex = 9;
            // 
            // textEditEmail
            // 
            this.textEditEmail.Location = new System.Drawing.Point(95, 132);
            this.textEditEmail.MenuManager = this.barManager1;
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Size = new System.Drawing.Size(254, 20);
            this.textEditEmail.StyleController = this.dataLayoutControl1;
            this.textEditEmail.TabIndex = 8;
            // 
            // textEditMobile
            // 
            this.textEditMobile.Location = new System.Drawing.Point(95, 108);
            this.textEditMobile.MenuManager = this.barManager1;
            this.textEditMobile.Name = "textEditMobile";
            this.textEditMobile.Properties.DisplayFormat.FormatString = "N0";
            this.textEditMobile.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditMobile.Properties.EditFormat.FormatString = "N0";
            this.textEditMobile.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditMobile.Size = new System.Drawing.Size(254, 20);
            this.textEditMobile.StyleController = this.dataLayoutControl1;
            this.textEditMobile.TabIndex = 7;
            // 
            // textEditTelephone
            // 
            this.textEditTelephone.Location = new System.Drawing.Point(95, 84);
            this.textEditTelephone.MenuManager = this.barManager1;
            this.textEditTelephone.Name = "textEditTelephone";
            this.textEditTelephone.Properties.DisplayFormat.FormatString = "N0";
            this.textEditTelephone.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditTelephone.Properties.EditFormat.FormatString = "N0";
            this.textEditTelephone.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditTelephone.Size = new System.Drawing.Size(254, 20);
            this.textEditTelephone.StyleController = this.dataLayoutControl1;
            this.textEditTelephone.TabIndex = 6;
            // 
            // textEditAddress
            // 
            this.textEditAddress.Location = new System.Drawing.Point(95, 60);
            this.textEditAddress.MenuManager = this.barManager1;
            this.textEditAddress.Name = "textEditAddress";
            this.textEditAddress.Size = new System.Drawing.Size(254, 20);
            this.textEditAddress.StyleController = this.dataLayoutControl1;
            this.textEditAddress.TabIndex = 5;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(95, 12);
            this.textEditName.MenuManager = this.barManager1;
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(254, 20);
            this.textEditName.StyleController = this.dataLayoutControl1;
            this.textEditName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlName,
            this.emptySpaceItem1,
            this.layoutControlAddress,
            this.layoutControlTelephone,
            this.layoutControlMobilePhone,
            this.layoutControlEmail,
            this.layoutControlComments,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(361, 199);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlName
            // 
            this.layoutControlName.Control = this.textEditName;
            this.layoutControlName.Location = new System.Drawing.Point(0, 0);
            this.layoutControlName.Name = "layoutControlName";
            this.layoutControlName.Size = new System.Drawing.Size(341, 24);
            this.layoutControlName.Text = "Ονοματεπώνυμο";
            this.layoutControlName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 168);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(341, 11);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlAddress
            // 
            this.layoutControlAddress.Control = this.textEditAddress;
            this.layoutControlAddress.Location = new System.Drawing.Point(0, 48);
            this.layoutControlAddress.Name = "layoutControlAddress";
            this.layoutControlAddress.Size = new System.Drawing.Size(341, 24);
            this.layoutControlAddress.Text = "Διεύθυνση";
            this.layoutControlAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlTelephone
            // 
            this.layoutControlTelephone.Control = this.textEditTelephone;
            this.layoutControlTelephone.Location = new System.Drawing.Point(0, 72);
            this.layoutControlTelephone.Name = "layoutControlTelephone";
            this.layoutControlTelephone.Size = new System.Drawing.Size(341, 24);
            this.layoutControlTelephone.Text = "Σταθερό Τηλ.";
            this.layoutControlTelephone.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlMobilePhone
            // 
            this.layoutControlMobilePhone.Control = this.textEditMobile;
            this.layoutControlMobilePhone.Location = new System.Drawing.Point(0, 96);
            this.layoutControlMobilePhone.Name = "layoutControlMobilePhone";
            this.layoutControlMobilePhone.Size = new System.Drawing.Size(341, 24);
            this.layoutControlMobilePhone.Text = "Κιν. Τηλ.";
            this.layoutControlMobilePhone.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlEmail
            // 
            this.layoutControlEmail.Control = this.textEditEmail;
            this.layoutControlEmail.Location = new System.Drawing.Point(0, 120);
            this.layoutControlEmail.Name = "layoutControlEmail";
            this.layoutControlEmail.Size = new System.Drawing.Size(341, 24);
            this.layoutControlEmail.Text = "E-mail";
            this.layoutControlEmail.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlComments
            // 
            this.layoutControlComments.Control = this.textEditComments;
            this.layoutControlComments.Location = new System.Drawing.Point(0, 144);
            this.layoutControlComments.Name = "layoutControlComments";
            this.layoutControlComments.Size = new System.Drawing.Size(341, 24);
            this.layoutControlComments.Text = "Σχόλια";
            this.layoutControlComments.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpEditTown;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem2.Text = "Πόλη";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 13);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(385, 223);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataLayoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(365, 203);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ClientSetupModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 247);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ClientSetupModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Νέος Πελάτης";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditComments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTelephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlTelephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMobilePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarButtonItem barButtonDelete;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit textEditEmail;
        private DevExpress.XtraEditors.TextEdit textEditMobile;
        private DevExpress.XtraEditors.TextEdit textEditTelephone;
        private DevExpress.XtraEditors.TextEdit textEditAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlTelephone;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlMobilePhone;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlEmail;
        private DevExpress.XtraEditors.TextEdit textEditComments;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlComments;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTown;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}