using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Ref_User_Types
    {
        [Key]
        public int UserTypeId { get; set; }
        public string? UserTypeCode { get; set; }

        [Required(ErrorMessage = "User type description is required")]
        [MaxLength(200, ErrorMessage = "User type description must be at most 200 characters long")]
        public string? UserTypeDescription { get; set; }

        //Navigational property
        public ICollection<Users> Users { get; set; }
    }
}

