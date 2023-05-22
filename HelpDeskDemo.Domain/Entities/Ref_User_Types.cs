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
        public int UserTypeCode { get; set; }


        public string? UserType { get; set; }

        //Navigational Properties Here
        public string? UserTypeDescription { get; set; }
        public ICollection<Users>? Users { get; set; }
    }
}

