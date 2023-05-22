using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Support_Staff
    {
        [Key]
        public int StaffId { get; set; }

        [DataType(DataType.Date)]
        public int DateJoined { get; set; }

        [DataType(DataType.Date)]
        public int DateLeft { get; set; }

        [Required(ErrorMessage = "Fullname is required")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100")]
        public string? StaffFullName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? StaffPhone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? StaffEmail { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100")]
        public string? StaffLocation { get; set; }

        [Required(ErrorMessage = "Staff details are required")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100")]
        public string StaffDetails { get; set; }
    }
}
