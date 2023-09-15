using BAL.Common;
using BAL.Models;
using BAL.Repository;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jim.Forms
{
    public partial class ProductSetupForm : DevExpress.XtraEditors.XtraForm
    {
        public ProductSetupForm()
        {
            InitializeComponent();
            using (var repository = new LookUpEditRepository())
            {
                var categories = repository.SetLookUpProductCategories();
                LookUpEditInitializer.SetLookUpEdit(lookUpEditProuctCategories, categories);                
            }
            UpdateData();
        }

        void UpdateData()
        {
            using (var repository = new ProductsRepository())
            {
                this.bindingSource.DataSource = repository.GetProducts();
            }
        }

        #region Events
        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSource.EndEdit();
            gridControl.EmbeddedNavigator.Buttons.DoClick(gridControl.EmbeddedNavigator.Buttons.EndEdit);
            var products = this.bindingSource.DataSource as List<ProductModel>;
            if (products.Any(x => string.IsNullOrEmpty(x.Designation)))
            {
                XtraMessageBox.Show("Υπάρχουν προϊόντα χωρίς ονομασία!");
                return;
            }
            using (var repository = new ProductsRepository())
            {
                repository.Save(products.Where(x => x.HasChanges).ToList());
            }
            UpdateData();
        }

        private void barButtonAddRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Append);
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DialogResult res = XtraMessageBox.Show(String.Format("Σίγουρα θέλετε να διαγραφεί;"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                var row = gridView.GetFocusedRow() as ProductModel;
                if (row.ProductID != null && row.ProductID != Guid.Empty)
                {
                    using (var repository = new ProductsRepository())
                    {
                        repository.Delete(row.ProductID);
                    }
                }
                this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Remove);
            }
        }
        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = gridView.GetFocusedRow() as ProductModel;
            row.HasChanges = true;
        }

        #endregion

    }
}