using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductID { get; set; }
        public string Designation { get; set; }
        public Guid? ProductCategoriesID { get; set; }

        [ForeignKey(nameof(ProductCategoriesID))]
        public virtual ProductCategories ProductCategories { get; set; }
        public decimal? Price { get; set; }
        public decimal? ProfitPercentage { get; set; }
    }
}
