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
        [Key]
        [ForeignKey(nameof(Staff_Skills))]


        public int Staff_Id { get; set; }
        [Key]
        [ForeignKey(nameof(Staff_Skills))]


        public int Staff_Code { get; set; }


        public int Date_Skilled_Obtained { get; set; }
    }
}
