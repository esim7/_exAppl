using AutoMapper;
using Domain.Models.Models;
using Infrastructure.Database.DTO;

namespace _exApp.Profiles
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<EApplicationDto, EApplication>();
        }
    }
}