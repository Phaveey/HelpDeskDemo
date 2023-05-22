using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IProblem_History
    {
        Task<IEnumerable<Problem_History>> GetAllAsync(bool trackChanges);
        Task<Problem_History> GetProblemHistoryById(int Id, bool trackChanges);
        void CreateProblemHistory(Problem_History entity);
        void UpdateProblemHistory(Problem_History entity);
        void DeleteProblemHistory(Problem_History entity);
    }
}
