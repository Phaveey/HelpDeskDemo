using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IRef_Priority_Levels
    {
        Task<IEnumerable<Ref_Priority_Levels>> GetAllAsync(bool trackChanges);
        Task<Ref_Priority_Levels> GetRefPriorityLevelsByCode(int Id, bool trackChanges);
        void CreateRefPriorityLevels(Ref_Priority_Levels entity);
        void UpdateRefPriorityLevels(Ref_Priority_Levels entity);
        void DeleteRefPriorityLevels(Ref_Priority_Levels entity);
    }

}

