using Abp.Domain.Entities.Auditing;
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
    
    public class Proje : FullAuditedEntity
    {
        //id tanımlanmalı mı 
        public string ProjeAdi { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Gorev> Gorevler { get; set; }
        public virtual ICollection<User> Developers { get; set; }
        public DurumEnum Durum { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime MusteriBitisTarihi { get; set; }

        [ForeignKey(nameof(MusteriId))]
        public int MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }





    }

}
