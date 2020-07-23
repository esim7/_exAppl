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
    public class EditApplicationRequestHandler : IRequestHandler<EditApplicationCommand, EApplicationDto>
    {
        private readonly IRepository<EApplication> _eapplicationRepository;
        private readonly IMapper _mapper;

        public EditApplicationRequestHandler(IRepository<EApplication> eapplicationRepository, IMapper mapper)
        {
            _eapplicationRepository = eapplicationRepository;
            _mapper = mapper;
        }

        public async Task<EApplicationDto> Handle(EditApplicationCommand request, CancellationToken cancellationToken)
        {
            var application = _eapplicationRepository.Update(request.ApplicationId,
                _mapper.Map<EApplication>(request.EApplicationDto));
            return _mapper.Map<EApplicationDto>(application);
        }
    }
}