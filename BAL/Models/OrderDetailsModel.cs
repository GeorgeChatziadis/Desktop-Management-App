using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class OrderDetailsModel
    {
        public Guid? OrderDetailsID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? OrderID { get; set; }
        public decimal? Quantity { get; set; }
        public bool? IsDone { get; set; }
        public decimal? ActualProfit { get; set; }
        public decimal? Profit { get; set; }
        public decimal? ProfitPercentage { get; set; }
        public decimal? Cost { get; set; }
        public bool? HasChanges { get; set; }
    }
}
