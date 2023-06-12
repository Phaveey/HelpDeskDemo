using HelpDeskDemo.Domain.Entities;

namespace HelpDeskDemo.Application.Contracts
{
    public interface IEquipmentRepository
    {
        Task<IEnumerable<Equipment>> GetAllEquipmentAsync(bool trackChanges);

        Task<Equipment> GetEquipmentById(int id, bool trackChanges);

        void CreateEquipment(Equipment equipment);

        void DeleteEquipment(Equipment equipment);

    }
}
