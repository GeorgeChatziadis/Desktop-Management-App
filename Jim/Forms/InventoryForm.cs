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
    public partial class InventoryForm : DevExpress.XtraEditors.XtraForm
    {
        public InventoryForm()
        {
            InitializeComponent();            
        }

        private void simpleButtonRetrieve_Click(object sender, EventArgs e)
        {
            bool? forMethod = UpdateBool();
            if (forMethod == null)
            {
                XtraMessageBox.Show("Διαλέξτε μία απο τις δύο επιλογές");
                return;
            }
            using (var repository = new InventoryRepository())
            {
                bindingSource.DataSource = repository.GetInventory(forMethod);
            }
            UpdateUI();
        }

        void UpdateUI()
        {
            if (checkEditProducts.Checked == true)
            {
                this.colMaterialName.Visible = false;
                this.colProductName.Visible = true;
                this.colProductName.VisibleIndex = 0;
            }

            if (checkEditMaterials.Checked == true)
            {
                this.colProductName.Visible = false;
                this.colMaterialName.Visible = true;
                this.colMaterialName.VisibleIndex = 0;
            }
        }

        bool? UpdateBool()
        {
            if (checkEditProducts.Checked == true && checkEditMaterials.Checked == false)
            {
                return true;
            }

            if (checkEditProducts.Checked == false && checkEditMaterials.Checked == true)
            {
                return false;
            }

            return null;
        }
    }
}