using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Ref_Equipment_Types
    {
        [Key]
        public int EquipmentTypeCode { get; set; }


        public string? Equipment_TypeDescription { get; set; }
    }
}
