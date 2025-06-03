using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyApi.Application.Queries;

namespace MyApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalVendorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExternalVendorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("chucvu123")]
        public async Task<IActionResult> GetAllJsonplaceholder()
        {
            var result = await _mediator.Send(new GetJsonplaceholderDataQuery());
            return Ok(result);
        }

        [HttpGet("randomten")]
        public async Task<IActionResult> GetTenJoke()
        {
            var result = await _mediator.Send(new GetTenJokeQuery());
            return Ok(result);
        }

        [HttpGet("randomjoke")]
        public async Task<IActionResult> GetRandomJoke()
        {
            var result = await _mediator.Send(new GetRandomJokeQuery());
            return Ok(result);
        }
    }
}
