using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDeskDemo.Domain.CommonEntity;

namespace HelpDeskDemo.Domain.Entities
{
    public class Equipment : AuditableBaseEntity
    {
        public int EquipmentId { get; set; }
        public int Type_code { get; set; }
        public DateTime AquiredDate { get; set; }
        public DateTime DisposeDate { get; set; }
        public int EquipmentCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ManufacturerName { get; set; }
        public bool IsAvailable { get; set; }
        public ICollection<Problems> Problem { get; set; }   

    }
}
