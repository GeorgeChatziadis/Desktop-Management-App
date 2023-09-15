using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class ProductCategoryModel
    {
        public Guid ProductCategoryID { get; set; }
        public string Designation { get; set; }
        public bool HasChanges { get; set; }
    }
}
