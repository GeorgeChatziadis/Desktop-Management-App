using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class TownModel
    {
        public Guid TownID { get; set; }
        public string TownDesignation { get; set; }
        public bool? HasChanges { get; set; }
    }
}
