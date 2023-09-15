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
    public partial class ProductPurchaseModal : DevExpress.XtraEditors.XtraForm
    {
        Guid modelID;
        bool isMaterial;
        PurchaseModel purchase = new PurchaseModel();
        public ProductPurchaseModal(bool material = false)
        {
            InitializeComponent();
            if (material == true)
            {
                using (var repository = new LookUpEditRepository())
                {
                    this.bindingSource.DataSource = repository.SetLookUpMaterials();
                }
                this.Text = "Αγορά υλικού";
                isMaterial = true;
            }
            else
            {
                using (var repository = new LookUpEditRepository())
                {
                    this.bindingSource.DataSource = repository.SetLookUpProducts();
                }
            }
            
            simpleButtonDelete.Enabled = false;
        }

        public ProductPurchaseModal(Guid purchaseID , bool materialForm = false)
        {
            InitializeComponent();

            if (materialForm == true)
            {
                using (var repository = new LookUpEditRepository())
                {
                    this.bindingSource.DataSource = repository.SetLookUpMaterials();
                }

                using (var repository = new PurchaseRepository())
                {
                    purchase = repository.GetMaterialPurchaseByID(purchaseID);
                }
                this.Text = "Αγορά υλικού";
                isMaterial = true;
            }
            else
            {
                using (var repository = new LookUpEditRepository())
                {
                    this.bindingSource.DataSource = repository.SetLookUpProducts();
                }

                using (var repository = new PurchaseRepository())
                {
                    purchase = repository.GetProductPurchaseByID(purchaseID);
                }
            }

            
            modelID = purchaseID;
            UpdateUI();
        }

        void UpdateUI()
        {
            if (isMaterial == true)
            {
                lookUpEditProduct.EditValue = purchase.MaterialID;
            }
            else
            {
                lookUpEditProduct.EditValue = purchase.ProductID;
            }
            lookUpEditProduct.Enabled = false;
            dateEdit.DateTime = purchase.Date;
            dateEdit.Enabled = false;
            spinEditCost.EditValue = purchase.Cost;
            spinEditCost.Enabled = false;
            spinEditQuantity.EditValue = purchase.Quantity;
            spinEditQuantity.Enabled = false;
            textEdit1.EditValue = purchase.Comments;
            textEdit1.Enabled = false;
            simpleButtonSave.Enabled = false;
        }

        void UpdateModel()
        {
            purchase.Comments = textEdit1.EditValue as string;
            purchase.Cost = spinEditCost.EditValue as decimal?;
            purchase.Date = dateEdit.DateTime;
            if (isMaterial == true)
            {
                purchase.MaterialID = lookUpEditProduct.EditValue as Guid?;
            }
            else
            {
                purchase.ProductID = lookUpEditProduct.EditValue as Guid?;
            }
            purchase.Quantity = spinEditQuantity.EditValue as decimal?;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            DialogResult res = XtraMessageBox.Show(String.Format("Είστε σίγουρος οτι θέλετε να αποθηκεύσετε;"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
            {
                return;
            }
            UpdateModel();
            using (var repository = new PurchaseRepository())
            {
                repository.Save(purchase);
            }
            Close();
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = XtraMessageBox.Show(String.Format("Είστε σίγουρος οτι θέλετε να διαγραφεί;"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
            {
                return;
            }

            using (var repository = new PurchaseRepository())
            {
                repository.Delete(modelID);
            }
            Close();
        }
    }
}