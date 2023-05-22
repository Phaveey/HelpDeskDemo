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

        [ForeignKey(nameof(Equipment))]
        public int EquipmentId { get; set; }

        [ForeignKey(nameof(Users))]
        public int UserId { get; set; }

        [DataType(DataType.Date)]
        public string? ProblemReportedDateTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Problem description is required")]
        [MaxLength(200, ErrorMessage = "Problem description must be at most 200 characters long")]
        public string? ProblemDescription { get; set; }

        public bool IsResolved { get; set; }

        //Navigational properties
        public Users? Users { get; set; }
        public virtual Equipment? Equipment { get; set; }
    }
}
