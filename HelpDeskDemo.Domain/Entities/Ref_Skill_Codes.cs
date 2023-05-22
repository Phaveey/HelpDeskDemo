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

        [Required(ErrorMessage = "Skill description is required")]
        [MaxLength(200, ErrorMessage = "Skill description must be at most 200 characters long")]
        public string? SkillDescription { get; set; }
    }   
}
