using Infrastructure.Database.DTO;
using MediatR;

namespace _exApp.Commands
{
    public class CreateApplicationCommand : IRequest<EApplicationDto>
    {
        public EApplicationDto EApplicationDto { get; }
        public CreateApplicationCommand(EApplicationDto eApplicationDto)
        {
            EApplicationDto = eApplicationDto;
        }
    }
}