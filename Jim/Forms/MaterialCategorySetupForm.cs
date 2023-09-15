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
    public partial class MaterialCategorySetupForm : DevExpress.XtraEditors.XtraForm
    {
        public MaterialCategorySetupForm()
        {
            InitializeComponent();
            UpdateData();
        }

        void UpdateData()
        {
            using (var repository = new MaterialCategoryRepository())
            {
                this.bindingSource.DataSource = repository.GetMaterialCategories();
            }
        }
        #region Events
        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = gridView.GetFocusedRow() as MaterialCategoryModel;
            row.HasChanges = true;
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSource.EndEdit();
            gridControl.EmbeddedNavigator.Buttons.DoClick(gridControl.EmbeddedNavigator.Buttons.EndEdit);
            var categories = this.bindingSource.DataSource as List<MaterialCategoryModel>;
            if (categories.Any(x => string.IsNullOrEmpty(x.Designation)))
            {
                XtraMessageBox.Show("Υπάρχουν κατηγορίες χωρίς ονομασία!");
                return;
            }
            using (var repository = new MaterialCategoryRepository())
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
            var row = gridView.GetFocusedRow() as MaterialCategoryModel;
            if (row.MaterialCategoryID != null && row.MaterialCategoryID != Guid.Empty)
            {
                using (var repository = new MaterialCategoryRepository())
                {
                    repository.Delete(row.MaterialCategoryID);
                }
            }
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Remove);
        }

        #endregion
    }
}