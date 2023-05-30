using HelpDeskDemo.Domain.Entities;

namespace HelpDeskDemo.Persistence.Repositories
{
    internal class EquipmentRepository
    {
        Task<IEnumerable<Equipment>> GetAllEquipmentAsync(bool trackChanges);

        Task<Equipment> GetHelpDeskAsync(int Id, bool trackChanges);

        Task<Equipment> GetEquipmentByName(string EquipmentName, bool trackChanges);

        void CreateEquipment(Equipment equipment);

        void DeleteEquipment(Equipment equipment);

    }
}
