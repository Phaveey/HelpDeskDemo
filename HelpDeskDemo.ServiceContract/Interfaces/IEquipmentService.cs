using HelpDeskDemo.Application.DTOs.DTOForCreation;
using HelpDeskDemo.Application.DTOs.DTOForDisplay;
using HelpDeskDemo.Application.DTOs.DTOForUpdate;
using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.ServiceContract.Interfaces
{
    public interface IEquipmentService
    {
        Task<IEnumerable<EquipmentDtoForDisplay>> GetAllEquipmentAsync(bool trackChanges);
        Task<EquipmentDtoForDisplay> GetEquipmentAsync(int id, bool trackChanges);
        Task<EquipmentDtoForDisplay> CreateEquipmentAsync(EquipmentDtoForCreation dtoForCreation);
        Task UpdateEquipmentAsync(int id, EquipmentDtoForUpdate equipmentDtoForUpdate, bool trackChanges);
        Task DeleteEquipmentAsync(int id, bool trackChanges);
    }   
}
