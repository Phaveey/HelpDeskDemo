using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Ref_User_Types
    {
      
        public int UserTypeId { get; set; }
        public string? UserType { get; set; }
        public string? UserTypeDescription { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}

