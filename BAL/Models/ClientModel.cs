using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class ClientModel
    {
        public Guid ClientID { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Comments { get; set; }
        public Guid? TownID { get; set; }
        public string TownDesignation { get; set; }
    }
}
