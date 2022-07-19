using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Projeler.Projeler.ProjelerDtos
{
    public class ProjeGuncelleDto
    {
        public int? ProjeId { get; set; }
        public string ProjeAdi { get; set; }
        public string Description { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DurumEnum Durum { get; set; }

    }
}
