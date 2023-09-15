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
    public partial class MaterialSetupForm : DevExpress.XtraEditors.XtraForm
    {
        public MaterialSetupForm()
        {
            InitializeComponent();
            using (var repository = new LookUpEditRepository())
            {
                var categories = repository.SetLookUpMaterialCategories();
                LookUpEditInitializer.SetLookUpEdit(lookUpEditMaterialCategories, categories);
            }
            UpdateData();
        }

        void UpdateData()
        {
            using (var repository = new MaterialRepository())
            {
                this.bindingSource.DataSource = repository.GetMaterials();
            }
        }
        #region Events

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSource.EndEdit();
            gridControl.EmbeddedNavigator.Buttons.DoClick(gridControl.EmbeddedNavigator.Buttons.EndEdit);
            var materials = this.bindingSource.DataSource as List<MaterialModel>;
            if (materials.Any(x => string.IsNullOrEmpty(x.Designation)))
            {
                XtraMessageBox.Show("Υπάρχουν υλικά χωρίς ονομασία!");
                return;
            }
            using (var repository = new MaterialRepository())
            {
                repository.Save(materials.Where(x => x.HasChanges).ToList());
            }
            UpdateData();
        }

        private void barButtonAddRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Append);
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridView.GetFocusedRow() as MaterialModel;
            if (row.MaterialID != null && row.MaterialID != Guid.Empty)
            {
                using (var repository = new MaterialRepository())
                {
                    repository.Delete(row.MaterialID);
                }
            }
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Remove);
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = gridView.GetFocusedRow() as MaterialModel;
            row.HasChanges = true;
        }

        #endregion


    }
}