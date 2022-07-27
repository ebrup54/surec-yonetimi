using Abp.Domain.Entities.Auditing;
using Acme.SimpleTaskApp.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Projeler
{
    [Table("Musteriler")]
    public class Musteri : FullAuditedEntity
    {
        public string MusteriAdi { get; set; }
        public string Iletisim { get; set; }
        public string Aciklama { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }
    }
}
