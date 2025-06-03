using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyApi.Application.Commands;
using MyApi.Application.Queries;
using MyApi.Core.Entities;

namespace MyApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("")]
        public async Task<IActionResult> AddEmployeeAsync(EmployeeEntity employee)
        {
            var result = await _mediator.Send(new AddEmployeeCommand(employee));
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployeesAsync()
        {
            var result = await _mediator.Send(new GetAllEmployeesQuery());
            return Ok(result);
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateEmployeeAsync(Guid id, [FromBody]EmployeeEntity employee)
        {
            var result = await _mediator.Send(new UpdateEmployeeCommand(id, employee));
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeAsync(Guid id)
        {
            var result = await _mediator.Send(new GetEmployeeByIdQuery(id));
            return Ok(result);
        }

        [HttpDelete("")]
        public async Task<IActionResult> DeleteEmployeeAsync([FromBody]Guid id)
        {
            var result = await _mediator.Send(new DeleteEmployeeCommand(id));
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
