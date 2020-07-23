using System.Threading;
using System.Threading.Tasks;
using _exApp.Commands;
using AutoMapper;
using Domain.Models.Models;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;

namespace _exApp.RequestHandlers
{
    public class CreateApplicationRequestHandler : IRequestHandler<CreateApplicationCommand, EApplicationDto>
    {
        private readonly IRepository<EApplication> _eapplicationRepository;
        private readonly IMapper _mapper;

        public CreateApplicationRequestHandler(IRepository<EApplication> eapplicationRepository, IMapper mapper)
        {
            _eapplicationRepository = eapplicationRepository;
            _mapper = mapper;
        }

        public async Task<EApplicationDto> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {

            var createdApplication = _mapper.Map<EApplication>(request.EApplicationDto);
            _eapplicationRepository.Create(createdApplication);
            

            return _mapper.Map<EApplicationDto>(createdApplication);
        }
    }
}