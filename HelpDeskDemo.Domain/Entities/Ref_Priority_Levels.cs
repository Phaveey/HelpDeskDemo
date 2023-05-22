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


        public string? Priority_Level_Description { get; set; }
    }
}

