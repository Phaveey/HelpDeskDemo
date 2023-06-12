using AutoMapper;
using HelpDeskDemo.Application.DTOs.DTOForCreation;
using HelpDeskDemo.Application.DTOs.DTOForUpdate;
using HelpDeskDemo.Domain.Entities;

namespace HelpDeskDemo.WebApi
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping() 
        {
            CreateMap<Equipment, Equipment>();
            CreateMap<EquipmentDtoForCreation, Equipment>();
            CreateMap<EquipmentDtoForUpdate, Equipment>();
        } 
    }
}
