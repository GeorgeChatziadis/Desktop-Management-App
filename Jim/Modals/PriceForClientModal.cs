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

namespace Jim.Modals
{
    public partial class PriceForClientModal : DevExpress.XtraEditors.XtraForm
    {
        List<PriceForClientModel> listToDelete = new List<PriceForClientModel>();
        public PriceForClientModal()
        {
            InitializeComponent();
            using (var repository = new LookUpEditRepository())
            {
                var products = repository.SetLookUpProducts();
                LookUpEditInitializer.SetLookUpEdit(repositoryItemLookUpEditProducts, products);
                this.bindingSourceClients.DataSource = repository.SetLookUpClients();
            }
            this.bindingSource.DataSource = new List<PriceForClientModel>();
            barButtonDeleteRecord.Enabled = false;
        }

        public PriceForClientModal(Guid clientID)
        {
            InitializeComponent();
            using (var repository = new LookUpEditRepository())
            {
                var products = repository.SetLookUpProducts();
                LookUpEditInitializer.SetLookUpEdit(repositoryItemLookUpEditProducts, products);
                this.bindingSourceClients.DataSource = repository.SetLookUpClients();
            }

            using (var repository = new PriceForClientRepository())
            {
                this.bindingSource.DataSource = repository.GetPricesForClient(clientID);
            }

            SetOldPrices();
            lookUpEdit1.EditValue = clientID;
            lookUpEdit1.Enabled = false;
        }

        void SetOldPrices()
        {
            bindingSource.EndEdit();
            gridControl.EmbeddedNavigator.Buttons.DoClick(gridControl.EmbeddedNavigator.Buttons.EndEdit);
            gridView.SelectAll();
            foreach (int rowHandle in gridView.GetSelectedRows())
            {
                using (var repository = new PriceForClientRepository())
                {
                    var row = gridView.GetRow(rowHandle) as PriceForClientModel;
                    if (row != null)
                    {
                        if (row.ProductID != null)
                        {
                            gridView.SetRowCellValue(rowHandle, gridView.Columns["OldPrice"], repository.ProductPrice(row.ProductID));
                        }
                    }                    
                }
            }
        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Append);
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Remove);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetOldPrices();
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            gridControl.EmbeddedNavigator.Buttons.DoClick(gridControl.EmbeddedNavigator.Buttons.EndEdit);
            
            using (var repository = new PriceForClientRepository())
            {
                if (lookUpEdit1.EditValue != null)
                {
                    var list = this.bindingSource.DataSource as List<PriceForClientModel>;
                    if (list != null)
                    {
                        if (list.Count > 0)
                        {
                            if (list.Any(x => x.NewPrice == null && (x.PriceForClientID == null || x.PriceForClientID == Guid.Empty)))
                            {
                                XtraMessageBox.Show("Υπάρχουν εγγραφές χωρίς νέα τιμή!");
                                return;
                            }
                            else
                            {
                                string result = repository.Save(list, (Guid)lookUpEdit1.EditValue);
                                if (result == "nope")
                                {
                                    XtraMessageBox.Show("Υπάρχουν ήδη εγγραφές για κάποια προϊόντα!");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            Close();
        }

        private void barButtonDeleteRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult res = XtraMessageBox.Show(String.Format("Είστε σίγουρος οτι θέλετε να διαγραφεί;"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                using (var repository = new PriceForClientRepository())
                {
                    repository.Delete((Guid)lookUpEdit1.EditValue);
                }
                Close();
            }
        }
    }
}