using Infrastructure.Database.DTO;
using MediatR;

namespace _exApp.Commands
{
    public class RemoveApplicationCommand : IRequest<EApplicationDto>
    {
        public int ApplicationId { get; }

        public RemoveApplicationCommand(int id)
        {
            ApplicationId = id;
        }
    }
}