using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Ref_Problem_Status_Codes
    {
        [Key]
        public int ProblemStatusCode { get; set; }

        [Required(ErrorMessage = "Problem status description is required")]
        [MaxLength(30, ErrorMessage = "Problem status description must be at most 200 characters long")]
        public string? ProblemStatusDescription { get; set; }
    }
}

