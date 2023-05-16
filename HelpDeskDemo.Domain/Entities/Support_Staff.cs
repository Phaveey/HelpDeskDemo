using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Support_Staff
    {
        public int Staff_Id { get; set; }
        public int Date_Joined { get; set; }
        public int Date_Left { get; set; }
        public string? Staff_FullName { get; set; }
        public string? Staff_Phone { get; set; }
        public string? Staff_Email { get; set; }
        public string? Staff_Location { get; set; }
        public string Staff_Details { get; set; }
    }
}
