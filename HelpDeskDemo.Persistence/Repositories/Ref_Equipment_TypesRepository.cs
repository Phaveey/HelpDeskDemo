using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class Ref_Equipment_TypesRepository : IRef_Equipment_TypesRepository
    {
        public void CreateRef_Equipment_Types(Ref_Equipment_Types ref_Equipment_Types)
        {
            throw new NotImplementedException();
        }

        public void DeleteRef_Equipment_Types(Ref_Equipment_Types ref_Equipment_Types)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ref_Equipment_Types>> GetAllRef_Equipment_TypesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ref_Equipment_Types> GetHelpDeskAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ref_Equipment_Types> GetRef_Equipment_TypesName(string Ref_Equipment_TypesName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
