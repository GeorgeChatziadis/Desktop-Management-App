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
    public partial class TownSetupForm : DevExpress.XtraEditors.XtraForm
    {
        public TownSetupForm()
        {
            InitializeComponent();
            using (var repository = new TownRepository())
            {
                this.bindingSource.DataSource = repository.GetTowns();
            }
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSource.EndEdit();
            gridControl.EmbeddedNavigator.Buttons.DoClick(gridControl.EmbeddedNavigator.Buttons.EndEdit);
            List<TownModel> listToSave = this.bindingSource.DataSource as List<TownModel>;
            using (var repository = new TownRepository())
            {
                repository.Save(listToSave.Where(x => x.HasChanges == true).ToList());
            }
        }

        private void barButtonAddRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Append);
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Remove);
            var row = gridView.GetFocusedRow() as TownModel;
            if (row.TownID != null)
            {
                using (var repository = new TownRepository())
                {
                    repository.Delete(row);
                }
            }
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = gridView.GetFocusedRow() as TownModel;
            if (row != null)
            {
                row.HasChanges = true;
            }
        }
    }
}