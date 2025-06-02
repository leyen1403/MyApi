using MediatR;
using MyApi.Core.Interfaces;

namespace MyApi.Application.Commands
{
    public record DeleteEmployeeCommand(Guid id) : IRequest<bool>;
    
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken token)
        {
            return await _employeeRepository.DeleteEmployeeAsync(request.id);
        }
    }
}
