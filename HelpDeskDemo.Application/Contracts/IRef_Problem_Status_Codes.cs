using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IRef_Problem_Status_Codes
    {
        Task<IEnumerable<Ref_Problem_Status_Codes>> GetAllAsync(bool trackChanges);
        Task<Ref_Problem_Status_Codes> GetRefProblemStatusByCode(int Id, bool trackChanges);
        void CreateRefProblemStatusCodes(Ref_Problem_Status_Codes entity);
        void UpdateRefProblemStatusCodes(Ref_Problem_Status_Codes entity);
        void DeleteRefProblemStatusCodes(Ref_Problem_Status_Codes entity);
    }
}
