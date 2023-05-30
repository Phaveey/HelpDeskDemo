using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.CommonEntity
{
    public abstract class AuditableBaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = null!;
        public string? ModifiedBy { get; set; }
    }
}
