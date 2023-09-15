using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class ProductModel
    {
        public Guid ProductID { get; set; }
        public string Designation { get; set; }        
        public Guid? ProductCategoryID { get; set; }
        public decimal? Price { get; set; }

        public bool HasChanges { get; set; }
    }
}
