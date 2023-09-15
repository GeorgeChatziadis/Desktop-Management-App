using DAL.Entities;
using BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repository
{
    public class InventoryRepository : Repository
    {
        public InventoryRepository() : base() { }
        public InventoryRepository(Context context) : base(context) { }

        public List<InventoryModel> GetInventory(bool? products)
        {
            if (products == true)
            {
                var inventory = Context.Inventory.Where(x => x.ProductID != null && x.ProductID != Guid.Empty).Select(x => new InventoryModel
                {
                    ProductName = x.Product.Designation,
                    Quantity = x.Quantity,
                    QuantityForOrders = x.QuantityForOrders,
                    Balance = x.Quantity - x.QuantityForOrders
                }).OrderBy(x => x.Balance).ToList();
                return inventory;
            }
            else
            {
                var inventory = Context.Inventory.Where(x => x.MaterialID != null && x.MaterialID != Guid.Empty).Select(x => new InventoryModel
                {
                    MaterialName = x.Material.Designation,
                    Quantity = x.Quantity,
                    QuantityForOrders = x.QuantityForOrders,
                    Balance = x.Quantity - x.QuantityForOrders
                }).OrderBy(x => x.Balance).ToList();
                return inventory;
            }           

        }
    
    }
}
