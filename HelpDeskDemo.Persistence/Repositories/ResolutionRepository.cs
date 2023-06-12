using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class ResolutionRepository : IResolutionRepository
    {
        public void CreateResolution(Resolution resolution)
        {
            throw new NotImplementedException();
        }

        public void DeleteResolution(Resolution resolutions)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Resolution>> GetAllResolutionsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Resolution> GetHelpDeskAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Resolution> GetResolution(string ResolutionName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
