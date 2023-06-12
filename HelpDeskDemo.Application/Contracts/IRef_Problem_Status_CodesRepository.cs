using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IRef_Problem_Status_CodesRepository
    {
        Task<IEnumerable<Ref_Problem_Status_Codes>> GetAllRef_Problem_Status_CodesAsync(bool trackChanges);

        Task<Ref_Problem_Status_Codes> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Ref_Problem_Status_Codes> GetRef_Problem_Status_CodesByName(int Ref_Problem_Status_CodesName, bool trackChanges);

        void CreateRef_Priority_Levels(Ref_Problem_Status_Codes ref_Problem_Status_Codes);

        void DeleteRef_Priority_Levels(Ref_Problem_Status_Codes ref_Problem_Status_Codes);
    }
}
