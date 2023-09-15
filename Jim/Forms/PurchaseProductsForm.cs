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
    public partial class PurchaseProductsForm : DevExpress.XtraEditors.XtraForm
    {
        public PurchaseProductsForm()
        {
            InitializeComponent();
            using (var repository = new LookUpEditRepository())
            {
                bindingSourceProducts.DataSource = repository.SetLookUpProducts();
            }
        }

        CriteriaModel GetCriteria()
        {
            CriteriaModel criteria = new CriteriaModel();
            if (lookUpProducts.EditValue != null)
            {
                criteria.ProductID = (Guid)lookUpProducts.EditValue;
            }
            criteria.DateFrom = dateEditFrom.DateTime;
            criteria.DateTo = dateEditΤο.DateTime;

            return criteria;
        }

        void UpdateData()
        {
            dateEditFrom.DateTime = DateTime.Today;
            dateEditΤο.DateTime = DateTime.Today;
            simpleButtonRetrieve_Click(null, null);
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            var row = gridView.GetFocusedRow() as PurchaseModel;
            if (row != null)
            {
                if (row.ProductPurchaseID != null && row.ProductPurchaseID != Guid.Empty)
                {
                    ProductPurchaseModal modal = new ProductPurchaseModal(row.ProductPurchaseID);
                    modal.ShowDialog();
                    simpleButtonRetrieve_Click(null, null);
                }
            }
        }

        private void barButtonAddRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductPurchaseModal modal = new ProductPurchaseModal();
            modal.ShowDialog();
            UpdateData();
        }

        private void lookUpProducts_KeyDown(object sender, KeyEventArgs e)
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
                this.bindingSource.DataSource = repository.GetProductPurchases(GetCriteria());
            }
        }
    }
}