using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IProblemsRepository
    {
        Task<IEnumerable<Problems>> GetAllProblemtAsync(bool trackChanges);

        Task<Problems> GetProblemsAsync(int Id, bool trackChanges);

        void CreateProblem(Problems problems);

        void DeleteProblem(Problems problems);
    }
}
