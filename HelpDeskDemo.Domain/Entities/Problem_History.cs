using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public  class Problem_History
    {
        public int Problem_HistoryId { get; set; }
        public int Prority_LevelCode { get; set; }
        public int Problem_Id { get; set; }
        public string? Status_Code { get; set; }
        public int Assign_Staff_Id { get; set; }
        public string? Fix_DateTime { get; set; }
        public Problems Problems { get; set; }
        public ICollection<Resolution> Resolutions { get; set; }
        public 
       
    }
}
