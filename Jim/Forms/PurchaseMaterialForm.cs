using BAL.Models;
using BAL.Repository;
using DevExpress.XtraEditors;
using Jim.Modals;
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
    public partial class PurchaseMaterialForm : DevExpress.XtraEditors.XtraForm
    {
        public PurchaseMaterialForm()
        {
            InitializeComponent();
            using (var repository = new LookUpEditRepository())
            {
                bindingSourceMaterials.DataSource = repository.SetLookUpMaterials();
            }
        }

        CriteriaModel GetCriteria()
        {
            CriteriaModel criteria = new CriteriaModel();
            if (lookUpEdit1.EditValue != null)
            {
                criteria.MaterialID = (Guid)lookUpEdit1.EditValue;
            }
            criteria.DateFrom = dateEditFrom.DateTime;
            criteria.DateTo = dateEditTo.DateTime;

            return criteria;
        }

        void UpdateData()
        {
            dateEditFrom.DateTime = DateTime.Today;
            dateEditTo.DateTime = DateTime.Today;
            simpleButtonRetrieve_Click(null, null);
        }


        private void lookUpEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }

        private void simpleButtonRetrieve_Click(object sender, EventArgs e)
        {
            using (var repository = new PurchaseRepository())
            {
                this.bindingSource.DataSource = repository.GetMaterialPurchase(GetCriteria());
            }
        }

        private void barButtonItemAddRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductPurchaseModal modal = new ProductPurchaseModal(true);
            modal.ShowDialog();
            UpdateData();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            var row = gridView.GetFocusedRow() as PurchaseModel;
            if (row != null)
            {
                if (row.ProductPurchaseID != null && row.ProductPurchaseID != Guid.Empty)
                {
                    ProductPurchaseModal modal = new ProductPurchaseModal(row.ProductPurchaseID,true);
                    modal.ShowDialog();
                    simpleButtonRetrieve_Click(null, null);
                }
            }
        }
    }
}