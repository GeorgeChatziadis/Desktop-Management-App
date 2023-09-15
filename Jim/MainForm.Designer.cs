
namespace Jim
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonClients = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonProducts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMaterials = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonProductCategories = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMaterialCategories = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOrders = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPriceForClients = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPurchaseOfMaterials = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPurhaseProducts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonProductInventory = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTownSetup = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupSetup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupProducts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupMaterials = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupCategories = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPagePriceforClients = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupTown = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageTransactions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageOrders = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPagePurchase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonInventory = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageInventory = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonClients,
            this.barButtonProducts,
            this.barButtonMaterials,
            this.barButtonProductCategories,
            this.barButtonMaterialCategories,
            this.barButtonOrders,
            this.barButtonPriceForClients,
            this.barButtonPurchaseOfMaterials,
            this.barButtonPurhaseProducts,
            this.barButtonProductInventory,
            this.barButtonTownSetup});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageSetup,
            this.ribbonPageTransactions,
            this.ribbonInventory});
            this.ribbon.Size = new System.Drawing.Size(1274, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonClients
            // 
            this.barButtonClients.Caption = "Πελάτες";
            this.barButtonClients.Id = 1;
            this.barButtonClients.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonClients.ImageOptions.SvgImage")));
            this.barButtonClients.Name = "barButtonClients";
            this.barButtonClients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonClients_ItemClick);
            // 
            // barButtonProducts
            // 
            this.barButtonProducts.Caption = "Προϊόντα";
            this.barButtonProducts.Id = 3;
            this.barButtonProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonProducts.ImageOptions.SvgImage")));
            this.barButtonProducts.Name = "barButtonProducts";
            this.barButtonProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonProducts_ItemClick);
            // 
            // barButtonMaterials
            // 
            this.barButtonMaterials.Caption = "Πρώτες Ύλες";
            this.barButtonMaterials.Id = 4;
            this.barButtonMaterials.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonMaterials.ImageOptions.SvgImage")));
            this.barButtonMaterials.Name = "barButtonMaterials";
            this.barButtonMaterials.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMaterials_ItemClick);
            // 
            // barButtonProductCategories
            // 
            this.barButtonProductCategories.Caption = "Κατηγορίες Προϊόντων";
            this.barButtonProductCategories.Id = 5;
            this.barButtonProductCategories.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonProductCategories.ImageOptions.SvgImage")));
            this.barButtonProductCategories.Name = "barButtonProductCategories";
            this.barButtonProductCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonProductCategories_ItemClick);
            // 
            // barButtonMaterialCategories
            // 
            this.barButtonMaterialCategories.Caption = "Κατηγορίες Υλικών";
            this.barButtonMaterialCategories.Id = 6;
            this.barButtonMaterialCategories.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonMaterialCategories.ImageOptions.SvgImage")));
            this.barButtonMaterialCategories.Name = "barButtonMaterialCategories";
            this.barButtonMaterialCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMaterialCategories_ItemClick);
            // 
            // barButtonOrders
            // 
            this.barButtonOrders.Caption = "Παραγγελίες";
            this.barButtonOrders.Id = 7;
            this.barButtonOrders.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonOrders.ImageOptions.SvgImage")));
            this.barButtonOrders.Name = "barButtonOrders";
            this.barButtonOrders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonOrders_ItemClick);
            // 
            // barButtonPriceForClients
            // 
            this.barButtonPriceForClients.Caption = "Ειδικές Τιμές Πελατών";
            this.barButtonPriceForClients.Id = 8;
            this.barButtonPriceForClients.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonPriceForClients.ImageOptions.SvgImage")));
            this.barButtonPriceForClients.Name = "barButtonPriceForClients";
            this.barButtonPriceForClients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPriceForClients_ItemClick);
            // 
            // barButtonPurchaseOfMaterials
            // 
            this.barButtonPurchaseOfMaterials.Caption = "Αγορά Υλικών";
            this.barButtonPurchaseOfMaterials.Id = 9;
            this.barButtonPurchaseOfMaterials.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonPurchaseOfMaterials.ImageOptions.SvgImage")));
            this.barButtonPurchaseOfMaterials.Name = "barButtonPurchaseOfMaterials";
            this.barButtonPurchaseOfMaterials.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPurchaseOfMaterials_ItemClick);
            // 
            // barButtonPurhaseProducts
            // 
            this.barButtonPurhaseProducts.Caption = "Αγορά Προϊόντων";
            this.barButtonPurhaseProducts.Id = 10;
            this.barButtonPurhaseProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonPurhaseProducts.ImageOptions.SvgImage")));
            this.barButtonPurhaseProducts.Name = "barButtonPurhaseProducts";
            this.barButtonPurhaseProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPurhaseProducts_ItemClick);
            // 
            // barButtonProductInventory
            // 
            this.barButtonProductInventory.Caption = "Αποθήκη Προϊόντων και Υλικών";
            this.barButtonProductInventory.Id = 11;
            this.barButtonProductInventory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonProductInventory.ImageOptions.SvgImage")));
            this.barButtonProductInventory.Name = "barButtonProductInventory";
            this.barButtonProductInventory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonProductInventory_ItemClick);
            // 
            // barButtonTownSetup
            // 
            this.barButtonTownSetup.Caption = "Πόλεις";
            this.barButtonTownSetup.Id = 12;
            this.barButtonTownSetup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonTownSetup.ImageOptions.SvgImage")));
            this.barButtonTownSetup.Name = "barButtonTownSetup";
            this.barButtonTownSetup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTownSetup_ItemClick);
            // 
            // ribbonPageSetup
            // 
            this.ribbonPageSetup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupSetup,
            this.ribbonPageGroupProducts,
            this.ribbonPageGroupMaterials,
            this.ribbonPageGroupCategories,
            this.ribbonPagePriceforClients,
            this.ribbonPageGroupTown});
            this.ribbonPageSetup.Name = "ribbonPageSetup";
            this.ribbonPageSetup.Text = "Παραμετροποίηση";
            // 
            // ribbonPageGroupSetup
            // 
            this.ribbonPageGroupSetup.ItemLinks.Add(this.barButtonClients);
            this.ribbonPageGroupSetup.Name = "ribbonPageGroupSetup";
            // 
            // ribbonPageGroupProducts
            // 
            this.ribbonPageGroupProducts.ItemLinks.Add(this.barButtonProducts);
            this.ribbonPageGroupProducts.Name = "ribbonPageGroupProducts";
            // 
            // ribbonPageGroupMaterials
            // 
            this.ribbonPageGroupMaterials.ItemLinks.Add(this.barButtonMaterials);
            this.ribbonPageGroupMaterials.Name = "ribbonPageGroupMaterials";
            // 
            // ribbonPageGroupCategories
            // 
            this.ribbonPageGroupCategories.ItemLinks.Add(this.barButtonProductCategories);
            this.ribbonPageGroupCategories.ItemLinks.Add(this.barButtonMaterialCategories);
            this.ribbonPageGroupCategories.Name = "ribbonPageGroupCategories";
            this.ribbonPageGroupCategories.Text = "Κατηγορίες";
            // 
            // ribbonPagePriceforClients
            // 
            this.ribbonPagePriceforClients.ItemLinks.Add(this.barButtonPriceForClients);
            this.ribbonPagePriceforClients.Name = "ribbonPagePriceforClients";
            // 
            // ribbonPageGroupTown
            // 
            this.ribbonPageGroupTown.ItemLinks.Add(this.barButtonTownSetup);
            this.ribbonPageGroupTown.Name = "ribbonPageGroupTown";
            // 
            // ribbonPageTransactions
            // 
            this.ribbonPageTransactions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageOrders,
            this.ribbonPagePurchase});
            this.ribbonPageTransactions.Name = "ribbonPageTransactions";
            this.ribbonPageTransactions.Text = "Κινήσεις";
            // 
            // ribbonPageOrders
            // 
            this.ribbonPageOrders.ItemLinks.Add(this.barButtonOrders);
            this.ribbonPageOrders.Name = "ribbonPageOrders";
            // 
            // ribbonPagePurchase
            // 
            this.ribbonPagePurchase.ItemLinks.Add(this.barButtonPurhaseProducts);
            this.ribbonPagePurchase.ItemLinks.Add(this.barButtonPurchaseOfMaterials);
            this.ribbonPagePurchase.Name = "ribbonPagePurchase";
            this.ribbonPagePurchase.Text = "Αγορές";
            // 
            // ribbonInventory
            // 
            this.ribbonInventory.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageInventory});
            this.ribbonInventory.Name = "ribbonInventory";
            this.ribbonInventory.Text = "Αποθήκη";
            // 
            // ribbonPageInventory
            // 
            this.ribbonPageInventory.ItemLinks.Add(this.barButtonProductInventory);
            this.ribbonPageInventory.Name = "ribbonPageInventory";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 646);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1274, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 670);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSetup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSetup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonClients;
        private DevExpress.XtraBars.BarButtonItem barButtonProducts;
        private DevExpress.XtraBars.BarButtonItem barButtonMaterials;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMaterials;
        private DevExpress.XtraBars.BarButtonItem barButtonProductCategories;
        private DevExpress.XtraBars.BarButtonItem barButtonMaterialCategories;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCategories;
        private DevExpress.XtraBars.BarButtonItem barButtonOrders;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageTransactions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageOrders;
        private DevExpress.XtraBars.BarButtonItem barButtonPriceForClients;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPagePriceforClients;
        private DevExpress.XtraBars.BarButtonItem barButtonPurchaseOfMaterials;
        private DevExpress.XtraBars.BarButtonItem barButtonPurhaseProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPagePurchase;
        private DevExpress.XtraBars.BarButtonItem barButtonProductInventory;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonInventory;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageInventory;
        private DevExpress.XtraBars.BarButtonItem barButtonTownSetup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupTown;
    }
}