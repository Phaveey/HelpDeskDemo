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
        Task<IEnumerable<Problems>> GetAllAsync(bool trackChanges);
        Task<Problems> GetProblemsById(int Id, bool trackChanges);
        void CreateProblem(Problems entity);
        void UpdateProblem(Problems entity);
        void DeleteProblemHistory(Problems entity);
    }
}

