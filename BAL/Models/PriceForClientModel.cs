using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
    public class PriceForClientModel
    {
        public Guid PriceForClientID { get; set; }
        public Guid ProductID { get; set; }
        public Guid ClientID { get; set; }
        public decimal? NewPrice { get; set; }
        public decimal? OldPrice { get; set; }
        public string ClientName { get; set; }
    }
}
