using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDeskDemo.Domain.CommonEntity;

namespace HelpDeskDemo.Domain.Entities
{
    public class Problems:AuditableBaseEntity
    {
        [Key]
        public int ProblemId { get; set; }
        [ForeignKey(nameof(Problems))]

        public int EquipmentId { get; set; }
        [ForeignKey(nameof(Problems))]

        public int UserId { get; set; }

        public string? Problem_Reported_DateTime { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        public string? ProblemDescription { get; set; }

        public bool IsResolved { get; set; }

        //Navigational Properities Here
        public Users? Users { get; set; }
        public virtual Equipment? Equipment { get; set; }
    }
}
