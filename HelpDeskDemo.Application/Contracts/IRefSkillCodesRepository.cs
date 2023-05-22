using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IRefSkillCodesRepository
    {
        Task<IEnumerable<Ref_Skill_Codes>> GetAllAsync(bool trackChanges);
        Task<Ref_Skill_Codes> GetRefSkillByCode(string Code, bool trackChanges);
        void CreateRefSkillCodes(Ref_Skill_Codes entity);
        void UpdateRefSkillCodes(Ref_Skill_Codes entity);
        void DeleteRefSkillCodes(Ref_Skill_Codes entity);
    }
}
