using DevExpress.XtraEditors;
using System;
using BAL.Models;
using BAL.Repository;
using System.Collections.Generic;
using Jim.Modals;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jim.Forms
{
    public partial class OrdersForm : DevExpress.XtraEditors.XtraForm
    {
        bool? isDone = null;
        public OrdersForm()
        {
            InitializeComponent();
            using (var repository = new LookUpEditRepository())
            {
                this.bindingSourceClientLookUp.DataSource = repository.SetLookUpClients();
                this.bindingSourceTowns.DataSource = repository.SetLookUpTowns();
            }
        }

        CriteriaModel GetCriteria()
        {
            CriteriaModel criteria = new CriteriaModel();
            criteria.DateFrom = dateEditFrom.DateTime;
            criteria.DateTo = dateEditTo.DateTime;
            criteria.IsDone = isDone;
            criteria.ClientID = lookUpEditClient.EditValue as Guid?;
            criteria.TownID = lookUpEditTown.EditValue as Guid?;
            return criteria;
        }

        private void simpleButtonRetrieve_Click(object sender, EventArgs e)
        {
            using (var repository = new OrderRepository())
            {
                this.bindingSource.DataSource = repository.GetOrders(GetCriteria());
            }
        }

        private void checkEditIsDone_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditIsDone.Checked == true)
            {
                isDone = true;
            }
            if (checkEditIsDone.Checked == false)
            {
                isDone = false;
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            var row = gridView.GetFocusedRow() as OrderModel;
            if (row != null)
            {
                if (row.OrderID != null && row.OrderID != Guid.Empty)
                {
                    OrderModal modal = new OrderModal(row.OrderID);
                    modal.ShowDialog();

                    //Για να γυρίσω την εγγραφή πίσω
                    CriteriaModel criteria = new CriteriaModel();
                    criteria.DateFrom = modal.Date;
                    criteria.DateTo = modal.Date;

                    using (var repository = new OrderRepository())
                    {
                        this.bindingSource.DataSource = repository.GetOrders(criteria);
                    }
                }
            }
        }

        private void barButtonNewOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OrderModal modal = new OrderModal();
            modal.ShowDialog();

            CriteriaModel criteria = new CriteriaModel();
            criteria.DateFrom = modal.Date;
            criteria.DateTo = modal.Date;

            using (var repository = new OrderRepository())
            {
                this.bindingSource.DataSource = repository.GetOrders(criteria);
            }
        }

        private void lookUpEditClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }

        private void lookUpEditTown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }

        private void lookUpEditTown_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditTown.EditValue != null)
            {
                using (var repository = new LookUpEditRepository())
                {

                    this.bindingSourceClientLookUp.DataSource = repository.SetLookUpClientsForTown((Guid?)lookUpEditTown.EditValue);
                }
            }

            if (lookUpEditTown.EditValue == null)
            {
                using (var repository = new LookUpEditRepository())
                {

                    this.bindingSourceClientLookUp.DataSource = repository.SetLookUpClients();
                    lookUpEditClient.EditValue = null;
                }
            }            
        }

        
    }
}