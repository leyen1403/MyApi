using MediatR;
using MyApi.Core.Entities;
using MyApi.Core.Interfaces;

namespace MyApi.Application.Queries
{
    public record GetAllEmployeesQuery : IRequest<IEnumerable<EmployeeEntity>>;

    public class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeEntity>>
    {
        private readonly IEmployeeRepository employeeRepository;

        public GetAllEmployeesQueryHandler(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeesAsync();
        }
    }
}
