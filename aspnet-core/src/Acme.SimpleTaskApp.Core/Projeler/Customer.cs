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
    [Table("Customers")]
    public class Customer : FullAuditedEntity
    {
        public string CustomerName { get; set; }

        public string CustomerContact { get; set; }
        public string Description { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }
    }
}
