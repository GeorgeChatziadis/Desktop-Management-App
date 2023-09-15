using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderDetailsID { get; set; }
        public Guid ProductID { get; set; }
        [ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }
        public Guid OrderID { get; set; }
        [ForeignKey(nameof(OrderID))]
        public virtual Order Order { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Profit { get; set; }
        public decimal? PercentageOfProfit { get; set; }
        public decimal? ActualProfit { get; set; }
        public decimal? Cost { get; set; }
        public bool? IsDone { get; set; }
    }
}
