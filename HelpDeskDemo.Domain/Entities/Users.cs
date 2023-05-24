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
        public int User_Id { get; set; }


        [ForeignKey(nameof(Users))]
        public int User_Type_Code { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string? FullName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? User_PhoneNumber { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string? User_EmailAdd { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string? Other_user_details { get; set; }

        //Navigational Properties Here
        public Ref_User_Types? Ref_User_Types { get; set; }
        public ICollection<Problems>? Problems { get; set; }

    }
}
