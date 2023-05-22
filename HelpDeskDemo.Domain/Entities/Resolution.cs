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
        public int Resolution_Id { get; set; }
        [ForeignKey(nameof(Resolution))]


        public int Problem_History_Id { get; set; }


        public string? Resolution_Description { get; set; }
    }
}

