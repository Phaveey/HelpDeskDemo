using HelpDeskDemo.Application.Contracts;
using HelpDeskDemo.Domain.Entities;
using HelpDeskDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Repositories
{
    public class EquipmentRepository : RepositoryBase<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
        public void CreateEquipment(Equipment equipment)
        {
           Create(equipment);
        }

        public void DeleteEquipment(Equipment equipment)
        {
            Delete(equipment);
        }

        public async Task<IEnumerable<Equipment>> GetAllEquipmentAsync(bool trackChanges)
        {
           return await FindAllAsync(trackChanges)
            .ToListAsync();
        }

        public async Task<Equipment> GetEquipmentById(int id, bool trackChanges)
        {
            var equipment =  FindByCondition(equipment =>equipment.Id.Equals(id), trackChanges).FirstOrDefault();
            return equipment;
        }

       
    }
}
