using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Models;

namespace BAL.Repository
{
    public class OrderRepository : Repository
    {
        public OrderRepository() : base() { }
        public OrderRepository(Context context) : base(context) { }

        public List<OrderModel> GetOrders(CriteriaModel criteria)
        {
            using (var context = new Context())
            {
                var orders = context.Order.AsQueryable();

                if (criteria.TownID != null && criteria.TownID != Guid.Empty)
                {
                    orders = orders.Where(x => x.Client.Town.TownID == criteria.TownID).AsQueryable();
                }
                if (criteria.ClientID != null && criteria.ClientID != Guid.Empty)
                {
                    orders = orders.Where(x => x.ClientID == criteria.ClientID).AsQueryable();
                }
                if (criteria.DateFrom != null && criteria.DateFrom != DateTime.MinValue)
                {
                    orders = orders.Where(x => x.Date >= criteria.DateFrom).AsQueryable();
                }
                if (criteria.DateTo != null && criteria.DateTo != DateTime.MinValue)
                {
                    orders = orders.Where(x => x.Date <= criteria.DateTo).AsQueryable();
                }
                if (criteria.IsDone == true)
                {
                    orders = orders.Where(x => x.IsDone == true).AsQueryable();
                }

                var list = (from x in orders
                            join y in context.Client on x.ClientID equals y.ClientID
                            select new OrderModel
                            {
                                Date = x.Date,
                                DueDate = x.DueDate,
                                ClientName = y.Name,
                                Comments = x.Comments,
                                Profit = x.Profit,
                                TimeSpent = x.TimeSpent,
                                OrderID = x.OrderID,
                                IsDone = x.IsDone,
                                IsPaid = x.IsPaid,
                                ActualProfit = x.ActualProfit
                            }).OrderBy(x => x.Date).ToList();

                return list;
            }
        }

        public OrderModel GetOrder(Guid orderID)
        {
            using (var context = new Context())
            {
                var order = context.Order.Where(x => x.OrderID == orderID).Select(x => new OrderModel
                {
                    Date = x.Date,
                    ClientID = x.ClientID,
                    Comments = x.Comments,
                    DueDate = x.DueDate,
                    IsDone = x.IsDone,
                    OrderID = x.OrderID,
                    Profit = x.Profit,
                    TimeSpent = x.TimeSpent,
                    ClientName = x.Client.Name,
                    IsPaid = x.IsPaid
                }).FirstOrDefault();

                return order;
            }
        }

        public List<OrderDetailsModel> GetOrderDetails(Guid orderID) //Δεδομένα OrderDetails για Order που υπάρχουν
        {
            using (var context = new Context())
            {
                var orderDetails = context.OrderDetails.Where(x => x.OrderID == orderID).Select(x => new OrderDetailsModel
                {
                    ProductID = x.ProductID,
                    ActualProfit = x.ActualProfit,
                    IsDone = x.IsDone,
                    OrderDetailsID = x.OrderDetailsID,
                    Profit = x.Profit,
                    ProfitPercentage = x.PercentageOfProfit,
                    Quantity = x.Quantity,
                    Cost = x.Cost                    
                }).OrderBy(x => x.Quantity).ToList();

                return orderDetails;
            }
        }

        public void Save(OrderModel order, List<OrderDetailsModel> details , bool isDone) //Δημιουργία - αλλίως Update
        {
            if (order.OrderID == null || order.OrderID == Guid.Empty)
            {
                decimal price = 0;
                decimal? actualProfit = 0;
                foreach (var item in details)
                {
                    price += ((decimal)item.Profit * (decimal)item.Quantity);
                    actualProfit += item.ActualProfit;
                }
                order.Profit = price;
                order.ActualProfit = actualProfit;
                Create(order, details);
            }
            else
            {
                decimal price = 0;
                decimal? actualProfit = 0;
                foreach (var item in details)
                {
                    price += ((decimal)item.Profit * (decimal)item.Quantity);
                    actualProfit += item.ActualProfit;
                }
                order.Profit = price;
                order.ActualProfit = actualProfit;
                Update(order, details, isDone);
            }
        }

        public void Delete(Guid orderID) //Διαγραφη Order - Ενημέρωση του Inventory - Διαγραφή αντίστοιχων OrderDetails
        {
            using (var context = new Context())
            {
                var details = context.OrderDetails.Where(x => x.OrderID == orderID).ToList();
                var order = context.Order.Where(x => x.OrderID == orderID).FirstOrDefault();
                foreach (var item in details)
                {
                    UpdateInventoryOnDelete(item.ProductID, item.Quantity, order.IsDone != null ? (bool)order.IsDone : false);
                    context.OrderDetails.Remove(item);
                }


                var orderToDelete = context.Order.Where(x => x.OrderID == orderID).FirstOrDefault();
                context.Order.Remove(orderToDelete);
                context.SaveChanges();
            }
        }

        public void DeleteDetails(List<Guid> detailIDs) //Για να διαγράφω μεμονομένες εγγραφές για συγκεκριμένο Order
        {
            var details = Context.OrderDetails.ToList();
            var inventory = Context.Inventory.ToList();
            foreach (Guid id in detailIDs)
            {
                var entity = details.Where(x => x.OrderDetailsID == id).FirstOrDefault();
                if (entity != null)
                {
                    var entityInv = inventory.Where(x => x.ProductID == entity.ProductID).FirstOrDefault();
                    entityInv.QuantityForOrders -= entity.Quantity;
                    Context.OrderDetails.Remove(entity);
                }
            }
            Context.SaveChanges();
        }

        public void Create(OrderModel order, List<OrderDetailsModel> details)
        {
            Order entity = new Order
            {
                ClientID = order.ClientID,
                Date = order.Date,
                DueDate = order.DueDate,
                IsDone = order.IsDone != null ? order.IsDone : false,
                Comments = order.Comments,
                TimeSpent = order.TimeSpent,
                IsPaid = order.IsPaid,
                ActualProfit = order.ActualProfit,
                Profit = order.Profit
            };

            Context.Order.Add(entity);
            if (details.Count > 0)
            {
                CreateDetails(details, entity);
            }
        }

        public void CreateDetails(List<OrderDetailsModel> details, Order entity)
        {
            foreach (var item in details)
            {
                OrderDetails orderDetails = new OrderDetails
                {
                    Order = entity,
                    ProductID = (Guid)item.ProductID,
                    IsDone = item.IsDone != null ? item.IsDone : false,
                    ActualProfit = item.ActualProfit,
                    PercentageOfProfit = item.ProfitPercentage,
                    Profit = item.Profit,
                    Quantity = item.Quantity
                };

                UpdateInventoryNewRecords((Guid)item.ProductID, item.Quantity, item.IsDone,true);
                Context.OrderDetails.Add(orderDetails);
            }
            Context.SaveChanges();
        }

        public void Update(OrderModel order, List<OrderDetailsModel> details, bool isDone)
        {
            using (var context = new Context())
            {
                var entity = context.Order.Where(x => x.OrderID == order.OrderID).FirstOrDefault();

                entity.ClientID = order.ClientID;
                entity.Comments = order.Comments;
                entity.Date = order.Date;
                entity.DueDate = order.DueDate;
                entity.TimeSpent = order.TimeSpent;
                entity.Profit = order.Profit;
                entity.IsPaid = order.IsPaid;
                entity.ActualProfit = order.ActualProfit;
                if (details.Count > 0)
                {
                    if (!isDone) //Αυτο σημαινει πως εχει γινει 
                    {
                        var orderDetails = context.OrderDetails.AsQueryable();
                        foreach (var item in details.Where(x => x.HasChanges == true))
                        {
                            if (item.OrderDetailsID != null && item.OrderDetailsID != Guid.Empty) //Δηλαδή αν ήδη υπάρχει η εγγραφή
                            {
                                var detail = orderDetails.Where(x => x.OrderDetailsID == item.OrderDetailsID).FirstOrDefault();

                                detail.PercentageOfProfit = item.ProfitPercentage;
                                detail.IsDone = item.IsDone;
                                detail.ProductID = (Guid)item.ProductID;
                                detail.Profit = item.Profit;
                                detail.ActualProfit = item.ActualProfit;
                                if (detail.Quantity != item.Quantity) //Για να ξερω αν πρεπει να ενημερωσω το Inventory
                                {
                                    UpdateInventory((Guid)item.ProductID, detail.Quantity, item.Quantity);
                                    detail.Quantity = item.Quantity;
                                }
                            }
                            else
                            {
                                OrderDetails orderDetailsNew = new OrderDetails
                                {
                                    Order = entity,
                                    ProductID = (Guid)item.ProductID,
                                    IsDone = item.IsDone,
                                    ActualProfit = item.ActualProfit,
                                    PercentageOfProfit = item.ProfitPercentage,
                                    Profit = item.Profit,
                                    Quantity = item.Quantity
                                };

                                UpdateInventoryNewRecords((Guid)item.ProductID, item.Quantity, item.IsDone);
                                context.OrderDetails.Add(orderDetailsNew);
                            }
                        }
                    }
                    else if (isDone && entity.IsDone == false)
                    {
                        foreach (var item in details)
                        {
                            UpdateInventoryNewRecords((Guid)item.ProductID, item.Quantity, true);
                        }
                    }

                }
                entity.IsDone = order.IsDone;
                context.SaveChanges();
            }
        }

        public void UpdateInventory(Guid productID, decimal? previousQuantity, decimal? newQuantity) //Προσθέτω τη νέα ποσότητα και αφαιρώ την παλιά για να έχω σωστή ποσότητα στο Inventory
        {
            var inventory = this.Context.Inventory.Where(x => x.ProductID == productID).FirstOrDefault();
            inventory.QuantityForOrders -= previousQuantity;
            inventory.QuantityForOrders += newQuantity;

            Context.SaveChanges();
        }

        public void UpdateInventoryNewRecords(Guid productID, decimal? quantity, bool? IsDone, bool creatingEntity = false) //Η main μέθοδος που χρησιμοποιούμε για το Update του Inventory ανάλογα με το OrderDetails -  καλείται και στο Create και στο Update 
        {
            var inventory = this.Context.Inventory.Where(x => x.ProductID == productID).FirstOrDefault();
            if (IsDone == null || IsDone == false)
            {
                inventory.QuantityForOrders += quantity;
            }
            else if (IsDone == true && creatingEntity == false)
            {
                inventory.Quantity -= quantity;
                inventory.QuantityForOrders -= quantity;
            }
            else if (IsDone == true && creatingEntity == true) //Σε περίπτωση που κάνει Save με IsDone την πρώτη φορά που κάνει την παραγγελία --για να μην αφαιρεσει απο το Quantity for Orders
            {
                inventory.Quantity -= quantity;
            }

            Context.SaveChanges();
        }

        public void UpdateInventoryOnDelete(Guid productID , decimal? quantity, bool isDone) //Ενημέρωση του Inventory σε περίπτωση που κάποιο μεμονομένο OrderDetail αφαιρεθεί τότε να αφαιρέσει και το QuantityForOrders
        {
            var inventory = this.Context.Inventory.Where(x => x.ProductID == productID).FirstOrDefault();

            if (isDone)
            {
                inventory.Quantity += quantity;
            }
            else
            {
                inventory.QuantityForOrders -= quantity;
            }
            Context.SaveChanges();
        }
    }
}
