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
        public int ProblemHistoryId { get; set; }

        [ForeignKey(nameof(Ref_Priority_Levels))]
        public int ProrityLevelCode { get; set; }

        [ForeignKey (nameof(Problems))]
        public int ProblemId { get; set; }

        [ForeignKey(nameof(Ref_Problem_Status_Codes))]
        public string? ProblemStatusCode { get; set; }

        //public int AssignedStaffId { get; set; }
        //public string? FixDateTime { get; set; }

        //Navigational property
        public ICollection<Problems>? Problems { get; set; }
    }
}
