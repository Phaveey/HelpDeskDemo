using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDeskDemo.Domain.CommonEntity;

namespace HelpDeskDemo.Domain.Entities
{
    public class Equipment : AuditableBaseEntity
    {
        [Key]
        public int EquipmentId { get; set; }
        [ForeignKey(nameof(Equipment))]

        public int Type_code { get; set; }

     
        public DateTime AquiredDate { get; set; }

        public DateTime DisposeDate { get; set; }

        public int EquipmentCode { get; set; }
       
        [Required(ErrorMessage = "Description is rqeuired")]
        [MaxLength(20, ErrorMessage = "Name must be at most 20 characters")]
        public string? Name { get; set; }



        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "Manufacturer name is required")]
        [MaxLength(30, ErrorMessage = "Manufacturer name must be at most 30 characters")]
        public string? ManufacturerName { get; set; }

        public bool IsAvailable { get; set; }

        //Nagivational Properties Here
        public ICollection<Problems>? Problems { get; set; }  
        public Ref_Equipment_Types? ref_Equipment_Types { get; set; }

    }
}
