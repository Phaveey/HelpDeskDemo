using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class Support_StaffRepository : ISupport_StaffRepository
    {
        public void CreateSupport_Staff(Support_Staff support_Staff)
        {
            throw new NotImplementedException();
        }

        public void DeleteSupport_Staff(Support_Staff support_Staff)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Support_Staff>> GetAllSupport_StaffAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Support_Staff> GetHelpDeskAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Support_Staff> GetSupport_StaffName(string Support_StaffName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
