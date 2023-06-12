using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IRef_User_TypesRepository
    {
        Task<IEnumerable<Ref_User_Types>> GetAllRef_User_TypesAsync(bool trackChanges);

        Task<Ref_User_Types> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Ref_User_Types> GetRef_User_TypesName(string Ref_User_TypesName, bool trackChanges);

        void CreateRef_User_Types(Ref_User_Types ref_User_Types);

        void DeleteRef_User_Types(Ref_User_Types ref_User_Types);
    }
}
