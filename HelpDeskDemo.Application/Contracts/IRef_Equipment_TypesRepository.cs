using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IRef_Equipment_TypesRepository
    {
        Task<IEnumerable<Ref_Equipment_Types>> GetAllRef_Equipment_TypesAsync(bool trackChanges);

        Task<Ref_Equipment_Types> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Ref_Equipment_Types> GetRef_Equipment_TypesName(string Ref_Equipment_TypesName, bool trackChanges);

        void CreateRef_Equipment_Types(Ref_Equipment_Types ref_Equipment_Types);

        void DeleteRef_Equipment_Types(Ref_Equipment_Types ref_Equipment_Types);
    }
}
