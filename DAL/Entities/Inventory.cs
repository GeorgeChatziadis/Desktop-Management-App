using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DAL.Entities
{
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid InventoryID { get; set; }
        public Guid? ProductID { get; set; }

        [ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }
        public Guid? MaterialID { get; set; }

        [ForeignKey(nameof(MaterialID))]
        public virtual Material Material { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityForOrders { get; set; }
    }
}
