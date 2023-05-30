using System;
using System.Buffers.Text;
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

        [ForeignKey(nameof(Ref_Equipment_Types))]
        public int EquipmentTypeCode { get; set; }

        [DataType(DataType.Date)]

     
        public DateTime AquiredDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DisposeDate { get; set; }

        public int EquipmentCode { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [MaxLength(100, ErrorMessage ="Name must be at most 100 characters long")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [MaxLength(200, ErrorMessage = "Description must be at most 200 characters long")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Manufacturer's name is required")]
        [MaxLength(100, ErrorMessage = "Manufacturer's name must be at most 100 characters long")]
        public string? ManufacturerName { get; set; }

        public bool IsAvailable { get; set; }

        //Navigational properties
        public ICollection<Problems>? Problems { get; set; }  
        public Ref_Equipment_Types? refEquipmentTypes { get; set; }

    }
}
