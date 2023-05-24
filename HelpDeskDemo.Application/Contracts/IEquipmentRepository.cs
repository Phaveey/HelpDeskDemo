using HelpDeskDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace HelpDeskDemo.Application.Contracts
{
    public interface IEquipmentRepository
    {
        Task<IEnumerable<Equipment>> GetAllAsync(bool trackChanges);
        Task<Equipment> GetEquipmentById(int Id, bool trackChanges);
        void CreateEquipment(Equipment entity);
        void UpdateEquipment(Equipment entity);
        void DeleteEquipment(Equipment entity);
    }
}
