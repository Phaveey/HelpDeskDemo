using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Users
    {
       [Key]
       public int UserId { get; set; }

       [ForeignKey(nameof(Ref_User_Types))]
       public int UserTypeCode { get; set; }

       [Required(ErrorMessage ="Fullname is required")]
       [MaxLength(100, ErrorMessage ="Maximum character length is 100")]
       public string? FullName { get; set; }

       [DataType(DataType.PhoneNumber)]
       public string? UserPhoneNumber { get; set; }

       [DataType(DataType.EmailAddress)]
       public string? UserEmailAddress { get; set; }

       public string? OtherUserDetails { get; set; }

       //Navigational properties
       public Ref_User_Types? RefUserTypes { get; set; }
       public ICollection<Problems>? Problems { get; set; }

    }
}
