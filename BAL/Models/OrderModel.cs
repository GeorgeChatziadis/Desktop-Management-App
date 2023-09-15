using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class OrderModel
    {
        public Guid OrderID { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
        public decimal? Profit { get; set; }
        public decimal? ActualProfit { get; set; }
        public Guid? ClientID { get; set; }
        public decimal? TimeSpent { get; set; }
        public DateTime? DueDate { get; set; }
        public string ClientName { get; set; }

        public bool? IsDone { get; set; }
        public bool IsPaid { get; set; }
    }
}
