using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.DTOs.DTOForCreation
{
    public class Problem_HistoryDtoForCreation
    {
        public int Problem_HistoryId { get; set; }
        [ForeignKey(nameof(Problem_History))]

        public int Prority_LevelCode { get; set; }
        [ForeignKey(nameof(Problem_History))]

        public int Problem_Id { get; set; }
        [ForeignKey(nameof(Problem_History))]

        public string? Status_Code { get; set; }
        [ForeignKey(nameof(Problem_History))]

        public int Assign_Staff_Id { get; set; }
        [ForeignKey(nameof(Problem_History))]

        public string? Fix_DateTime { get; set; }
    }
}
