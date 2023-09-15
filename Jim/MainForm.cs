using DevExpress.XtraBars;
using Jim.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jim
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void ShowForm<TForm>() where TForm : Form, new()
        {
            var instance = this.MdiChildren.OfType<TForm>().FirstOrDefault();
            if (instance != null)
                instance.Activate();
            else
            {
                instance = new TForm();
                instance.MdiParent = this;
                instance.Show();
            }
        }

        private void barButtonClients_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<ClientSetupForm>();
        }

        private void barButtonProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<ProductSetupForm>();
        }

        private void barButtonMaterials_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<MaterialSetupForm>();
        }

        private void barButtonProductCategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<ProductCategorySetupForm>();
        }

        private void barButtonMaterialCategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<MaterialCategorySetupForm>();
        }

        private void barButtonOrders_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<OrdersForm>();
        }

        private void barButtonPriceForClients_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<PriceForClientSetupForm>();
        }

        private void barButtonTownSetup_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<TownSetupForm>();
        }

        private void barButtonPurhaseProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<PurchaseProductsForm>();
        }

        private void barButtonPurchaseOfMaterials_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<PurchaseMaterialForm>();
        }

        private void barButtonProductInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ShowForm<InventoryForm>();
        }
    }
}