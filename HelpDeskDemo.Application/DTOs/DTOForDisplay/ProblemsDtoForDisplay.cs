using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.DTOs.DTOForDisplay
{
    public class ProblemsDtoForDisplay
    {
        public int ProblemId { get; set; }
        [ForeignKey(nameof(Problems))]

        public int EquipmentId { get; set; }
        [ForeignKey(nameof(Problems))]

        public int UserId { get; set; }

        public string? Problem_Reported_DateTime { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        public string? ProblemDescription { get; set; }

        public bool IsResolved { get; set; }
    }
}
