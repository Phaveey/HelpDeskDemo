using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IResolution
    {
        Task<IEnumerable<Resolution>> GetAllResolutionsync(bool trackChanges);

        Task<Resolution> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Resolution> GetResolution(string ResolutionName, bool trackChanges);

        void CreateResolution(Resolution resolution);

        void DeleteResolution(Resolution resolutions);
    }
}
