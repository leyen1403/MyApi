using MyApi.Core.Entities;

namespace MyApi.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeEntity>> GetEmployeesAsync();

        Task<EmployeeEntity?> GetEmployeeByIdAsync(Guid id);

        Task<EmployeeEntity?> AddEmployeeAsync(EmployeeEntity entity);

        Task<EmployeeEntity?> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity entity);

        Task<bool> DeleteEmployeeAsync(Guid employeeId);
    }
}
