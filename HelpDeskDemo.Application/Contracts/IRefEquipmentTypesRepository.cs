using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IRefEquipmentTypesRepository
    {
        Task<IEnumerable<Ref_Equipment_Types>> GetAllAsync(bool trackChanges);
        Task<Ref_Equipment_Types> GetRefEquipmentTypesByCode(string Code, bool trackChanges);
        void CreateRefEquipmentTypes(Ref_Equipment_Types entity);
        void UpdateRefEquipmentTypes(Ref_Equipment_Types entity);
        void DeleteRefEquipmentTypes(Ref_Equipment_Types entity);
    }
}

