using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class Ref_Skill_CodesRepository : IRef_Skill_CodesRepository
    {
        public void CreateRef_Skill_Codes(Ref_Skill_Codes ref_Skill_Codes)
        {
            throw new NotImplementedException();
        }

        public void DeleteRef_Skill_Codes(Ref_Skill_Codes ref_Skill_Codes)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ref_Skill_Codes>> GetAllRef_Skill_CodesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ref_Skill_Codes> GetHelpDeskAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ref_Skill_Codes> GetRef_Skill_CodesByName(int Ref_Skill_CodesName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
