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
        public string? EquipmentTypeCode { get; set; }

        [Required(ErrorMessage = "Equipment type description is required")]
        [MaxLength(100, ErrorMessage = "Equipment type description must be at most 100 characters long")]
        public string? EquipmentTypeDescription { get; set; }
    }
}
