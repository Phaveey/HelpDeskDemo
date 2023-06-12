using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using HelpDeskDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class ProblemsRepository :RepositoryBase<Problems>, IProblemsRepository
    {
        public ProblemsRepository(RepositoryContext context):base(context)
        {
            
        }
        public void CreateProblem(Problems problems)
        {
            Create(problems);
        }

        public void DeleteProblem(Problems problems)
        {
            Delete(problems);
        }

        public async Task<IEnumerable<Problems>> GetAllProblemtAsync(bool trackChanges)
        {
           return await FindAllAsync(trackChanges).ToListAsync();
        }

        public async Task<Problems> GetProblemsAsync(int Id, bool trackChanges)
        {
           return await FindByCondition(problem => problem.Id.Equals(Id), trackChanges).FirstOrDefaultAsync();
        }

    }
}
