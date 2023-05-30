using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface ISupport_Staff
    {
        Task<IEnumerable<Support_Staff>> GetAllSupport_StaffAsync(bool trackChanges);

        Task<Support_Staff> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Support_Staff> GetSupport_StaffName(string Support_StaffName, bool trackChanges);

        void CreateSupport_Staff(Support_Staff support_Staff);

        void DeleteSupport_Staff(Support_Staff support_Staff);
    }
}
