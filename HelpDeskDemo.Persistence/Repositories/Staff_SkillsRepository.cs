using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class Staff_SkillsRepository : IStaff_SkillsRepository
    {
        public void CreateStaff_Skills(Staff_Skills staff_Skills)
        {
            throw new NotImplementedException();
        }

        public void DeleteStaff_Skills(Staff_Skills staff_Skills)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Staff_Skills>> GetAllStaff_SkillsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Staff_Skills> GetHelpDeskAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Staff_Skills> GetStaff_SkillsName(string Staff_SkillsName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
