using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class PurchaseModel
    {
        public Guid ProductPurchaseID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? MaterialID { get; set; }
        public decimal? Cost { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }
        public decimal? Quantity { get; set; }
        public string ProductName { get; set; }
    }
}
