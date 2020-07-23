using _exApp.DefaultResponses;
using Infrastructure.Database.DTO;
using MediatR;

namespace _exApp.Requests
{
    public class GetApplicationByIdRequest : IRequest<ApplicationDefaultResponse>
    {
        public int EapplicationId { get; }

        public GetApplicationByIdRequest(int id)
        {
            EapplicationId = id;
        }
    }
}