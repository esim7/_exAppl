using Infrastructure.Database.DTO;
using MediatR;

namespace _exApp.Requests
{
    public class GetApplicationByIdRequest : IRequest<EApplicationDto>
    {
        public int EapplicationId { get; }

        public GetApplicationByIdRequest(int id)
        {
            EapplicationId = id;
        }
    }
}