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
    public partial class PriceForClientSetupForm : DevExpress.XtraEditors.XtraForm
    {
        public PriceForClientSetupForm()
        {
            InitializeComponent();
            UpdateData();
        }

        void UpdateData()
        {
            using (var repository = new PriceForClientRepository())
            {
                this.bindingSource.DataSource = repository.GetClients();
            }
        }

        private void barButtonNewRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PriceForClientModal modal = new PriceForClientModal();
            modal.ShowDialog();
            UpdateData();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            var row = gridView.GetFocusedRow() as PriceForClientModel;
            if (row != null)
            {
                if (row.ClientID != null && row.ClientID != Guid.Empty)
                {
                    PriceForClientModal modal = new PriceForClientModal(row.ClientID);
                    modal.ShowDialog();
                    UpdateData();
                }
            }            
        }
    }
}