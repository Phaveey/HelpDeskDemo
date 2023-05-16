using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDeskDemo.Domain.CommonEntity;

namespace HelpDeskDemo.Domain.Entities
{
    public class Problems:AuditableBaseEntity
    {
        public int ProblemId { get; set; }
        public int EquipmentId { get; set; }
        public int UserId { get; set; }
        public string? Problem_Reported_DateTime { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? ProblemDescription { get; set; }
        public bool IsResolved { get; set; }
        public Users Users { get; set; }
        public Equipment Equipment { get; set; }
    }
}
