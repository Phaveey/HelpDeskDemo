using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    internal interface IResolution
    {
        Task<IEnumerable<Resolution>> GetAllAsync(bool trackChanges);
        Task<Resolution> GetResolutionById(int Id, bool trackChanges);
        void CreateResolution(Resolution entity);
        void UpdateResolution(Resolution entity);
        void DeleteResolution(Resolution entity);
    }
}
