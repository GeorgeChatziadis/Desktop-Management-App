using BAL.Common;
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
    public partial class ClientSetupForm : DevExpress.XtraEditors.XtraForm
    {
        public ClientSetupForm()
        {
            InitializeComponent();
        }

        private void ClientSetupForm_Load(object sender, EventArgs e)
        {            

            using (var repository = new ClientRepository())
            {
                this.bindingSource.DataSource = repository.GetClients();
            }
            
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            var row = gridView.GetFocusedRow() as ClientModel;
            if (row != null)
            {
                if (row.ClientID != null)
                {
                    ClientSetupModal modal = new ClientSetupModal(row.ClientID);
                    modal.ShowDialog();
                    UpdateData();
                }
            }            
        }

        private void barButtonAddRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClientSetupModal modal = new ClientSetupModal();
            modal.ShowDialog();
            UpdateData();
        }

        void UpdateData()
        {
            using (var repository = new ClientRepository())
            {
                this.bindingSource.DataSource = repository.GetClients();
            }
        }
    }
}