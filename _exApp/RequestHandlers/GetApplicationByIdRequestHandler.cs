using System.Net;
using System.Threading;
using System.Threading.Tasks;
using _exApp.DefaultResponses;
using _exApp.Requests;
using AutoMapper;
using Domain.Models.Models;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;
using Microsoft.VisualBasic;

namespace _exApp.RequestHandlers
{
    public class GetApplicationByIdRequestHandler : IRequestHandler<GetApplicationByIdRequest, ApplicationDefaultResponse>
    {
        private readonly IRepository<EApplication> _eapplicationRepository;
        private readonly IMapper _mapper;

        public GetApplicationByIdRequestHandler(IRepository<EApplication> eapplicationRepository, IMapper mapper)
        {
            _eapplicationRepository = eapplicationRepository;
            _mapper = mapper;
        }

        public async Task<ApplicationDefaultResponse> Handle(GetApplicationByIdRequest request, CancellationToken cancellationToken)
        {
            var application = _eapplicationRepository.GetById(request.EapplicationId);
            var response = new ApplicationDefaultResponse();

            if (application != null)
            {
                response.EApplicationDto = _mapper.Map<EApplicationDto>(application);
                response.StatusCode = HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ErrorMessage = "Student not found!";
            }

            return response;
        }
    }
}