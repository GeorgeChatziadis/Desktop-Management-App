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
    public partial class ClientSetupModal : DevExpress.XtraEditors.XtraForm
    {
        ClientModel client = new ClientModel();
        Guid? clientId;
        public ClientSetupModal()
        {
            InitializeComponent();
            using(var repository = new LookUpEditRepository())
            {
                bindingSource.DataSource = repository.SetLookUpTowns();
            }
        }

        public ClientSetupModal(Guid clientID)
        {
            InitializeComponent();
            using (var repository = new LookUpEditRepository())
            {
                bindingSource.DataSource = repository.SetLookUpTowns();
            }
            UpdateUI(clientID);
        }

        void UpdateUI(Guid clientID)
        {
            using (var repository = new ClientRepository())
            {
                client = repository.GetClient(clientID);
            }
            clientId = clientID;
            this.Text = client.Name;
            barButtonDelete.Enabled = true;

            textEditName.EditValue = client.Name;
            textEditAddress.EditValue = client.Address;
            textEditComments.EditValue = client.Comments;
            textEditEmail.EditValue = client.Email;
            textEditMobile.EditValue = client.Mobile;
            textEditTelephone.EditValue = client.Telephone;
            lookUpEditTown.EditValue = client.TownID;
        }

        void UpdateModel()
        {
            client.Name = textEditName.EditValue as string;
            client.Address = textEditAddress.EditValue as string;
            client.Email = textEditEmail.EditValue as string;
            client.Mobile = textEditMobile.EditValue as string;
            client.Telephone = textEditTelephone.EditValue as string;
            client.Comments = textEditComments.EditValue as string;
            if (lookUpEditTown.EditValue != null && (Guid?)lookUpEditTown.EditValue != Guid.Empty)
            {
                client.TownID = (Guid?)lookUpEditTown.EditValue;
            }
            if (clientId != null)
            {
                client.ClientID = (Guid)clientId;
            }
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateModel();
            if (string.IsNullOrEmpty(client.Name))
            {
                XtraMessageBox.Show("Ο πελάτης δεν έχει όνομα!");
                return;
            }
            using (var repository = new ClientRepository())
            {
                repository.Save(client);
            }

            Close();
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult res = XtraMessageBox.Show(String.Format("Είστε σίγουρος οτι θέλετε να διαγραφεί;"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                using (var repository = new ClientRepository())
                {
                    repository.Delete((Guid)clientId);
                }
                Close();
            }           

        }
    }
}