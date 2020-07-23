using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _exApp.Commands;
using _exApp.Requests;
using Domain.Models.Models;
using Infrastructure.Database.DTO;
using Infrastructure.Database.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _exApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EapplicationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EapplicationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var request = new GetApplicationByIdRequest(id);
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EApplicationDto eApplicationDto)
        {
            var createApplicationCommand = new CreateApplicationCommand(eApplicationDto);
            var response = await _mediator.Send(createApplicationCommand);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] EApplicationDto eApplicationDto)
        {
            var request = new EditApplicationRequest(id);
            var editApplicationCommand = new EditApplicationCommand(request, eApplicationDto);
            var response = await _mediator.Send(editApplicationCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var removeApplicationCommand = new RemoveApplicationCommand(id);
            var response = await _mediator.Send(removeApplicationCommand);

            return Ok(response);
        }
    }
}
