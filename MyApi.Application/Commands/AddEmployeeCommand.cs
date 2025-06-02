using MediatR;
using MyApi.Core.Entities;
using MyApi.Core.Interfaces;

namespace MyApi.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity EmployeeEntity) : IRequest<EmployeeEntity>;   
    
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        private readonly IEmployeeRepository employeeRepository;

        public AddEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.AddEmployeeAsync(request.EmployeeEntity);
        }


    }
}
