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
        Task<IEnumerable<Support_Staff>> GetAllAsync(bool trackChanges);
        Task<Support_Staff> GetSupportStaffById(int Id, bool trackChanges);
        void CreateSupportStaff(Support_Staff entity);
        void UpdateSupportStaff(Support_Staff entity);
        void DeleteSupportStaff(Support_Staff entity);
    }
}
