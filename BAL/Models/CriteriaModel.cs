using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class CriteriaModel
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Guid? ClientID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? MaterialID { get; set; }
        public Guid? TownID { get; set; }
        public bool? IsDone { get; set; }
    }
}
