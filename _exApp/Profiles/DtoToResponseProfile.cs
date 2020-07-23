using _exApp.DefaultResponses;
using AutoMapper;
using Infrastructure.Database.DTO;

namespace _exApp.Profiles
{
    public class DtoToResponseProfile : Profile
    {
        public DtoToResponseProfile()
        {
            CreateMap<EApplicationDto, ApplicationDefaultResponse>()
                .ForMember(c => c.EApplicationDto,
                    opt => opt.MapFrom(c => c));
        }
    }
}