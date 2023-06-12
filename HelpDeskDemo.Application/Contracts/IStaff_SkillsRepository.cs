using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IStaff_SkillsRepository
    {
        Task<IEnumerable<Staff_Skills>> GetAllStaff_SkillsAsync(bool trackChanges);

        Task<Staff_Skills> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Staff_Skills> GetStaff_SkillsName(string Staff_SkillsName, bool trackChanges);

        void CreateStaff_Skills(Staff_Skills staff_Skills);

        void DeleteStaff_Skills(Staff_Skills staff_Skills);
    }
}
