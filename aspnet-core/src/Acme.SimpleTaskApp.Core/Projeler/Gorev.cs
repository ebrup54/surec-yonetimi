using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using Acme.SimpleTaskApp.Authorization.Users;
using Acme.SimpleTaskApp.Projeler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Projeler
{
    [Table("Gorevler")]

    public class Gorev : FullAuditedEntity
    {
        public User Developer { get; set; }

        [ForeignKey(nameof(DeveloperId))]
        public int? DeveloperId { get; set; }

        public string GorevTanimi { get; set; }
        public DurumEnum Durum { get; set; }
        
        public DateTime BaslamaZamani { get; set; }

        public Proje Proje { get; set; }

        [ForeignKey(nameof(ProjeID))]
        public int? ProjeID { get; set; }
        public Gorev()
        {

            BaslamaZamani = Clock.Now;
   
        }





    }
}
