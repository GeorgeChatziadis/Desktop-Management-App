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
    public partial class ProductCategorySetupForm : DevExpress.XtraEditors.XtraForm
    {
        public ProductCategorySetupForm()
        {
            InitializeComponent();
            UpdateData();
        }
        void UpdateData()
        {
            using (var repository = new ProductCategoryRepository())
            {
                this.bindingSource.DataSource = repository.GetProductCategories();
            }
        }

        #region Events

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSource.EndEdit();
            gridControl.EmbeddedNavigator.Buttons.DoClick(gridControl.EmbeddedNavigator.Buttons.EndEdit);
            var categories = this.bindingSource.DataSource as List<ProductCategoryModel>;
            if (categories.Any(x => string.IsNullOrEmpty(x.Designation)))
            {
                XtraMessageBox.Show("Υπάρχουν κατηγορίες χωρίς ονομασία!");
                return;
            }
            using (var repository = new ProductCategoryRepository())
            {
                repository.Save(categories.Where(x => x.HasChanges).ToList());
            }
            UpdateData();
        }

        private void barButtonAddRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Append);
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridView.GetFocusedRow() as ProductCategoryModel;
            if (row.ProductCategoryID != null && row.ProductCategoryID != Guid.Empty)
            {
                using (var repository = new ProductCategoryRepository())
                {
                    repository.Delete(row.ProductCategoryID);
                }
            }
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Remove);
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = gridView.GetFocusedRow() as ProductCategoryModel;
            row.HasChanges = true;
        }

        #endregion
    }
}