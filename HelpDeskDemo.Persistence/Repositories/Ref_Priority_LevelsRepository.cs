using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class Ref_Priority_LevelsRepository : IRef_Priority_LevelsRepository
    {
        public void CreateRef_Priority_Levels(Ref_Priority_Levels ref_Priority_Levels)
        {
            throw new NotImplementedException();
        }

        public void DeleteRef_Priority_Levels(Ref_Priority_Levels ref_Priority_Levels)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ref_Priority_Levels>> GetAllRef_Priority_LevelsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ref_Priority_Levels> GetHelpDeskAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ref_Priority_Levels> GetRef_Priority_LevelsByName(string Ref_Priority_LevelsName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
