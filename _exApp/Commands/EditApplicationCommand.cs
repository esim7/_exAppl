using _exApp.Requests;
using Infrastructure.Database.DTO;
using MediatR;

namespace _exApp.Commands
{
    public class EditApplicationCommand : IRequest<EApplicationDto>
    {
        public int ApplicationId { get; }
        public EApplicationDto EApplicationDto { get; }

        public EditApplicationCommand(EditApplicationRequest request, EApplicationDto eApplicationDto)
        {
            ApplicationId = request.ApplicationId;
            EApplicationDto = eApplicationDto;
        }
    }
}