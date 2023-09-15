using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderID { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
        public decimal? Profit { get; set; }
        public decimal? ActualProfit { get; set; }
        public Guid? ClientID { get; set; }
        [ForeignKey(nameof(ClientID))]
        public virtual Client Client { get; set; }
        public decimal? TimeSpent { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? IsDone { get; set; }
        public bool IsPaid { get; set; }
    }
}
