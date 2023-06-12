using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IProblem_HistoryRepository
    {
        Task<IEnumerable<Problem_History>> GetAllProblem_HistorytAsync(bool trackChanges);

        Task<Problem_History> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Problem_History> GetProblem_HistoryByName(string EquipmentName, bool trackChanges);

        void CreateProblem_History(Problem_History problem_History);

        void DeleteProblem_History(Problem_History problem_History);
    }
}
