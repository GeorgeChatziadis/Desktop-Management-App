using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class InventoryModel
    {
        public Guid InventoryID { get; set; }
        public Guid? ProductID { get; set; }
        public string ProductName { get; set; }
        public Guid? MaterialID { get; set; }
        public string MaterialName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityForOrders { get; set; }
        public decimal? Balance { get; set; }
    }
}
