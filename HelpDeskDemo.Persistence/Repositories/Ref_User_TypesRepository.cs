using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class Ref_User_TypesRepository : IRef_User_TypesRepository
    {
        public void CreateRef_User_Types(Ref_User_Types ref_User_Types)
        {
            throw new NotImplementedException();
        }

        public void DeleteRef_User_Types(Ref_User_Types ref_User_Types)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ref_User_Types>> GetAllRef_User_TypesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ref_User_Types> GetHelpDeskAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ref_User_Types> GetRef_User_TypesName(string Ref_User_TypesName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
