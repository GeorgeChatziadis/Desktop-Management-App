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
    public partial class OrderModal : DevExpress.XtraEditors.XtraForm
    {
        List<Guid> detailsToDelete = new List<Guid>();
        OrderModel model = new OrderModel();
        List<PriceForClientModel> specialPrices = new List<PriceForClientModel>();
        public DateTime Date { get; set; }
        Guid _orderID;
        bool loading = true;
        public OrderModal()
        {
            InitializeComponent(); 
            using (var repository = new LookUpEditRepository())
            {
                var products = repository.SetLookUpProducts();
                LookUpEditInitializer.SetLookUpEdit(lookUpEditProducts, products);
                this.bindingSourceClients.DataSource = repository.SetLookUpClients();
                this.bindingSource.DataSource = new List<OrderDetailsModel>();
            }
        }        

        public OrderModal(Guid orderID)
        {
            InitializeComponent();
            using (var repository = new LookUpEditRepository())
            {
                var products = repository.SetLookUpProducts();
                LookUpEditInitializer.SetLookUpEdit(lookUpEditProducts, products);
                this.bindingSourceClients.DataSource = repository.SetLookUpClients();
            }
            _orderID = orderID;
            using (var repository = new OrderRepository())
            {
                this.bindingSource.DataSource = repository.GetOrderDetails(orderID);
                var order = repository.GetOrder(orderID);
                UpdateUI(order);
            }
            loading = false;
        }

        void UpdateUI(OrderModel order)
        {
            lookUpEditClients.EditValue = order.ClientID;
            lookUpEditClients.Enabled = false;
            textEditComments.EditValue = order.Comments;
            dateEditDate.DateTime = order.Date;
            if (order.IsDone != null)
            {
                checkEditIsDone.Checked = (bool)order.IsDone;
            }
            if (order.DueDate != null && order.DueDate != DateTime.MinValue)
            {
                dateEditDueDate.DateTime = (DateTime)order.DueDate;
            }
            spinEditTime.EditValue = order.TimeSpent;
            if (order.IsDone != null)
            {
                checkEditIsDone.Checked = (bool)order.IsDone;
            }
            checkEditPaid.Checked = model.IsPaid;
            barButtonDelete.Enabled = true;
            if (order.IsDone == true)
            {
                checkEditIsDone.Enabled = false;
            }
        }

        void UpdateModel()
        {
            if (_orderID != null && _orderID != Guid.Empty)
            {
                model.OrderID = _orderID;
            }
            model.ClientID = lookUpEditClients.EditValue as Guid?;
            model.Date = dateEditDate.DateTime;
            if (dateEditDueDate.DateTime != DateTime.MinValue)
            {
                model.DueDate = dateEditDueDate.DateTime;
            }
            model.TimeSpent = spinEditTime.EditValue as decimal?;
            model.Comments = textEditComments.EditValue as string;
            model.IsDone = checkEditIsDone.Checked;
            model.IsPaid = checkEditPaid.Checked;
        }

        bool ValidateData()
        {
            if (dateEditDate.DateTime == DateTime.MinValue)
            {
                XtraMessageBox.Show("Παρακαλώ προσθέστε Ημερομηνία!");
                return false;
            }
            if (lookUpEditClients.EditValue == null)
            {
                XtraMessageBox.Show("Παρακαλώ διαλέξτε πελάτη!");
                return false;
            }

            return true;
        }

        void SetPrices()
        {
            EndEdit();
            gridView.SelectAll();
            foreach (int rowHandle in gridView.GetSelectedRows())
            {
                using (var repository = new PriceForClientRepository())
                {
                    var row = gridView.GetRow(rowHandle) as OrderDetailsModel;
                    if (row != null)
                    {
                        if (row.ProductID != null)
                        {
                            if (!specialPrices.Any(x => x.ProductID == row.ProductID))
                            {
                                gridView.SetRowCellValue(rowHandle, gridView.Columns["Profit"], repository.ProductPrice((Guid)row.ProductID));
                            }
                            else if (lookUpEditClients.EditValue != null && (Guid)lookUpEditClients.EditValue != Guid.Empty)
                            {
                                gridView.SetRowCellValue(rowHandle, gridView.Columns["Profit"], repository.GetPriceForClientAndProduct((Guid)lookUpEditClients.EditValue, (Guid)row.ProductID));
                            }
                        }
                    }

                }
                gridView.UnselectRow(rowHandle);
            }
        }

        void SetProfits()
        {
            EndEdit();
            gridView.SelectAll();
            foreach (int rowHandle in gridView.GetSelectedRows())
            {
                using (var repository = new PriceForClientRepository())
                {
                    var row = gridView.GetRow(rowHandle) as OrderDetailsModel;
                    if (row != null)
                    {
                        if (row.Profit != null)
                        {
                            if (row.ProfitPercentage != null && row.Quantity != null && (row.Cost == null || row.Cost == 0))
                            {
                                gridView.SetRowCellValue(rowHandle, gridView.Columns["ActualProfit"], ((row.Quantity * row.Profit) * row.ProfitPercentage) / 100);
                            }
                            else if ((row.ProfitPercentage == null || row.ProfitPercentage == 0) && row.Quantity != null && row.Cost != null)
                            {

                                gridView.SetRowCellValue(rowHandle, gridView.Columns["ActualProfit"], ((row.Quantity * row.Profit)  - (row.Quantity * row.Cost)));
                            }
                        }
                    }

                }
            }
        }

        void EndEdit()
        {
            bindingSource.EndEdit();
            gridControl.EmbeddedNavigator.Buttons.DoClick(gridControl.EmbeddedNavigator.Buttons.EndEdit);
        }

        void HasSpecialPrices()
        {
            if (lookUpEditClients.EditValue == null || (Guid)lookUpEditClients.EditValue == Guid.Empty)
            {
                return;
            }

            using(var repository = new PriceForClientRepository())
            {
                specialPrices = repository.GetPricesForClient((Guid)lookUpEditClients.EditValue);
            }
        }

        private void barButtonAddProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Append);
        }

        private void barButtonDeleteProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridView.GetFocusedRow() as OrderDetailsModel;
            if (row.OrderDetailsID != null)
            {
                detailsToDelete.Add((Guid)row.OrderDetailsID);
            }
            this.gridControl.EmbeddedNavigator.Buttons.DoClick(this.gridControl.EmbeddedNavigator.Buttons.Remove);
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            EndEdit();
            UpdateModel();
            if (!ValidateData())
            {
                return;
            }
            if (model.IsDone == true)
            {
                DialogResult res = XtraMessageBox.Show(String.Format("Είστε σίγουρος οτι θέλετε να ολοκληρωθεί;"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    return;
                }
            }            
            var orderDetails = this.bindingSource.DataSource as List<OrderDetailsModel>;
            using (var repository = new OrderRepository())
            {
                repository.Save(model, orderDetails, checkEditIsDone.Checked);
                if (detailsToDelete != null && detailsToDelete.Count > 0)
                {
                    repository.DeleteDetails(detailsToDelete);
                }
            }
            Close();
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = gridView.GetFocusedRow() as OrderDetailsModel;
            row.HasChanges = true;
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult res = XtraMessageBox.Show(String.Format("Είστε σίγουρος οτι θέλετε να διαγραφεί;"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                using (var repository = new OrderRepository())
                {
                    repository.Delete(_orderID);
                }
                Close();
            }            
        }

        private void checkEditIsDone_CheckedChanged(object sender, EventArgs e)
        {

            if (checkEditIsDone.Checked == true)
            {
                dateEditDueDate.Enabled = true;
                var list = this.bindingSource.DataSource as List<OrderDetailsModel>;
                foreach (var item in list)
                {
                    item.IsDone = true;
                    item.HasChanges = true;
                }
                gridView.RefreshData();
            }
            else if (checkEditIsDone.Checked == false)
            {
                dateEditDueDate.Enabled = false;
                dateEditDueDate.EditValue = null;
                var list = this.bindingSource.DataSource as List<OrderDetailsModel>;
                foreach (var item in list)
                {
                    item.IsDone = false;
                    item.HasChanges = true;
                }
                gridView.RefreshData();
            }
        }

        private void lookUpEditProducts_EditValueChanged(object sender, EventArgs e)
        {
            SetPrices();
        }

        private void lookUpEditClients_EditValueChanged(object sender, EventArgs e)
        {
            HasSpecialPrices();
        }

        private void barButtonRefreshProfit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetProfits();
        }
    }
}