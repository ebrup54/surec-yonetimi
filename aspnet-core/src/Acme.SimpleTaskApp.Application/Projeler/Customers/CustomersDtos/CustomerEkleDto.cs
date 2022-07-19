using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Projeler.Customers.CustomersDtos
{
    public class CustomerEkleDto
    {
        public int? MusteriId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string Description { get; set; } 
    }
}
