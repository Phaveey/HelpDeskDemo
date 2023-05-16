using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Domain.Entities
{
    public class Resolution
    {
        public int Resolution_Id { get; set; }
        public int Problem_History_Id { get; set; }
        public string? Resolution_Description { get; set; }
    }
}

