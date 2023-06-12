using AutoMapper;
using HelpDeskDemo.Application.Common;
using HelpDeskDemo.Application.DTOs.DTOForCreation;
using HelpDeskDemo.Application.DTOs.DTOForDisplay;
using HelpDeskDemo.Application.DTOs.DTOForUpdate;
using HelpDeskDemo.Domain.Entities;
using HelpDeskDemo.ServiceContract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.ServiceRepository.Services
{
    internal sealed class EquipmentService : IEquipmentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public EquipmentService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;

        }

        public async Task<EquipmentDtoForDisplay> CreateEquipmentAsync(EquipmentDtoForCreation dtoForCreation)
        {
            var equipmentEntity = _mapper.Map<Equipment>(dtoForCreation);

            _repository.EquipmentRepository.CreateEquipment(equipmentEntity);
            await _repository.SaveAsync();

            var equipmentToReturn = _mapper.Map<EquipmentDtoForDisplay>(equipmentEntity);
            return equipmentToReturn;
         }

        public Task DeleteEquipmentAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EquipmentDtoForDisplay>> GetAllEquipmentAsync(bool trackChanges)
        {
                var getCustomerEntities = await _repository.EquipmentRepository.GetAllEquipmentAsync(trackChanges);

                var equipmentEntities = _mapper.Map<IEnumerable<EquipmentDtoForDisplay>>(getCustomerEntities);

                return equipmentEntities;
        }   

        public async Task<EquipmentDtoForDisplay> GetEquipmentAsync(int id, bool trackChanges)
        {
            var getEquipment = await _repository.EquipmentRepository.GetEquipmentById(id, trackChanges);
            var equipmentDto = _mapper.Map<EquipmentDtoForDisplay>(getEquipment);
            return equipmentDto;

        }

        public Task UpdateEquipmentAsync(int id, EquipmentDtoForUpdate equipmentDtoForUpdate, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }

}
