using System.Threading;
using System.Threading.Tasks;
using _exApp.Requests;
using AutoMapper;
using Domain.Models.Models;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;
using Microsoft.VisualBasic;

namespace _exApp.RequestHandlers
{
    public class GetApplicationByIdRequestHandler : IRequestHandler<GetApplicationByIdRequest, EApplicationDto>
    {
        private readonly IRepository<EApplication> _eapplicationRepository;
        private readonly IMapper _mapper;

        public GetApplicationByIdRequestHandler(IRepository<EApplication> eapplicationRepository, IMapper mapper)
        {
            _eapplicationRepository = eapplicationRepository;
            _mapper = mapper;
        }

        public async Task<EApplicationDto> Handle(GetApplicationByIdRequest request, CancellationToken cancellationToken)
        {
            var application = _eapplicationRepository.GetById(request.EapplicationId);
            return _mapper.Map<EApplicationDto>(application);
        }
    }
}