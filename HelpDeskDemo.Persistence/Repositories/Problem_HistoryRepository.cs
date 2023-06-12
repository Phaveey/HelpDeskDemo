using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using HelpDeskDemo.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class Problem_HistoryRepository : IProblem_HistoryRepository
    {   
        public Problem_HistoryRepository(RepositoryContext repositoryContext) 
        {

        }
        public void CreateProblem_History(Problem_History problem_History)
        {
            throw new NotImplementedException();
        }

        public void DeleteProblem_History(Problem_History problem_History)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Problem_History>> GetAllProblem_HistorytAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Problem_History> GetHelpDeskAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Problem_History> GetProblem_HistoryAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Problem_History> GetProblem_HistoryByName(string EquipmentName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
