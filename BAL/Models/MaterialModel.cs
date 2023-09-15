using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class MaterialModel
    {
        public Guid MaterialID { get; set; }
        public string Designation { get; set; }
        public Guid? MaterialCategoryID { get; set; }
        public bool HasChanges { get; set; }
    }
}
