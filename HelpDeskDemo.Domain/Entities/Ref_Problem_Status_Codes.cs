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


        public string? StatusDescription { get; set; }
    }
}

