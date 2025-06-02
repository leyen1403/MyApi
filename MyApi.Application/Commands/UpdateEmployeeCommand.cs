using MediatR;
using MyApi.Core.Entities;
using MyApi.Core.Interfaces;

namespace MyApi.Application.Commands
{
    public record UpdateEmployeeCommand(Guid id, EmployeeEntity Employee) : IRequest<EmployeeEntity>;

    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        private readonly IEmployeeRepository employeeRepository;

        public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.UpdateEmployeeAsync(request.id, request.Employee);
        }
    }
}
