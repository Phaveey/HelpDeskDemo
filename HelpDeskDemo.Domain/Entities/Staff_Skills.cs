using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Staff_Skills
    {
        [Key, Column(Order = 0)]
        [ForeignKey(nameof(Support_Staff))]
        public int StaffId { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey(nameof(Ref_Skill_Codes))]
        public int StaffCode { get; set; }

        [DataType(DataType.Date)]
        public int DateSkilledObtained { get; set; }
    }
}
