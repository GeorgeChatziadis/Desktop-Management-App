using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MaterialID { get; set; }
        public string Designation { get; set; }
        public Guid? MaterialCategoryID { get; set; }

        [ForeignKey(nameof(MaterialCategoryID))]
        public virtual MaterialCategories MaterialCategories { get; set; }
    }
}
