using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class PriceForClient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PriceForClientID { get; set; }
        public Guid ProductID { get; set; }
        [ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }
        public Guid ClientID { get; set; }
        [ForeignKey(nameof(ClientID))]
        public virtual Client Client { get; set; }
        public decimal? NewPrice { get; set; }
    }
}
