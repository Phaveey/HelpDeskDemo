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
        Task<IEnumerable<Ref_Priority_Levels>> GetAllRef_Priority_LevelsAsync(bool trackChanges);

        Task<Ref_Priority_Levels> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Ref_Priority_Levels> GetRef_Priority_LevelsByName(string Ref_Priority_LevelsName, bool trackChanges);

        void CreateRef_Priority_Levels(Ref_Priority_Levels ref_Priority_Levels);

        void DeleteRef_Priority_Levels(Ref_Priority_Levels ref_Priority_Levels);
    }
}
