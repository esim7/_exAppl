using Infrastructure.Database.DTO;
using MediatR;

namespace _exApp.Requests
{
    public class EditApplicationRequest : IRequest<EApplicationDto>
    {
        public int ApplicationId { get; }
        public EditApplicationRequest(int id)
        {
            ApplicationId = id;
        }
    }
}