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
    public class RemoveApplicationRequestHandler : IRequestHandler<RemoveApplicationCommand, EApplicationDto>
    {
        private readonly IRepository<EApplication> _eapplicationRepository;
        private readonly IMapper _mapper;

        public RemoveApplicationRequestHandler(IRepository<EApplication> eapplicationRepository, IMapper mapper)
        {
            _eapplicationRepository = eapplicationRepository;
            _mapper = mapper;
        }

        public async Task<EApplicationDto> Handle(RemoveApplicationCommand request, CancellationToken cancellationToken)
        {
            var removedStudent = _eapplicationRepository.Remove(request.ApplicationId);
            return _mapper.Map<EApplicationDto>(removedStudent);
        }
    }
}