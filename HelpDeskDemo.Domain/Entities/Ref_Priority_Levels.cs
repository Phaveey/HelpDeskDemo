using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Ref_Priority_Levels
    {
        [Key]
        public int Priority_Level_Code { get; set; }

        [Required(ErrorMessage = "Priority level description is required")]
        [MaxLength(200, ErrorMessage = "Priority level description must be at most 200 characters long")]
        public string? Priority_Level_Description { get; set; }
    }
}

