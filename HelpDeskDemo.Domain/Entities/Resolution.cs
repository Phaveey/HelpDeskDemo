using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Resolution
    {
        [Key]
        public int ResolutionId { get; set; }

        [ForeignKey(nameof(Problem_History))]
        public int ProblemHistoryId { get; set; }

        [Required(ErrorMessage = "Resolution description is required")]
        [MaxLength(200, ErrorMessage = "Resolution description must be at most 200 characters long")]
        public string? ResolutionDescription { get; set; }
    }
}

