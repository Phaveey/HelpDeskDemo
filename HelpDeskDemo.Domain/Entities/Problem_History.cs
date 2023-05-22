using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Problem_History
    {
        [Key]
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

        //Navigational Properties Here
        public Problems? Problems { get; set; }
        public ICollection<Resolution>? Resolutions { get; set; }
        public 
       
    }
}
