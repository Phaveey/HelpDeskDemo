using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IRef_Skill_CodesRepository
    {
        Task<IEnumerable<Ref_Skill_Codes>> GetAllRef_Skill_CodesAsync(bool trackChanges);

        Task<Ref_Skill_Codes> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Ref_Skill_Codes> GetRef_Skill_CodesByName(int Ref_Skill_CodesName, bool trackChanges);

        void CreateRef_Skill_Codes(Ref_Skill_Codes ref_Skill_Codes);

        void DeleteRef_Skill_Codes(Ref_Skill_Codes ref_Skill_Codes);
    }
}
