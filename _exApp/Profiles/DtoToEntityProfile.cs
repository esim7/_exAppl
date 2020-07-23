using AutoMapper;
using Domain.Models.Models;
using Infrastructure.Database.DTO;

namespace _exApp.Profiles
{
    public class DtoToEntityProfile: Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<EApplication, EApplicationDto>();
        }
    }
}