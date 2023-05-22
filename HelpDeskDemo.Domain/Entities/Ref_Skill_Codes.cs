using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Ref_Skill_Codes
    {
        [Key]

        public string? SkillCode { get; set; }


        public string? Description { get; set; }
    }   
}
