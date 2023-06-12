using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class Ref_Problem_Status_CodesRepository : IRef_Problem_Status_CodesRepository
    {
        public void CreateRef_Priority_Levels(Ref_Problem_Status_Codes ref_Problem_Status_Codes)
        {
            throw new NotImplementedException();
        }

        public void DeleteRef_Priority_Levels(Ref_Problem_Status_Codes ref_Problem_Status_Codes)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ref_Problem_Status_Codes>> GetAllRef_Problem_Status_CodesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ref_Problem_Status_Codes> GetHelpDeskAsync(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ref_Problem_Status_Codes> GetRef_Problem_Status_CodesByName(int Ref_Problem_Status_CodesName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
