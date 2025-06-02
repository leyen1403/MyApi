using Microsoft.EntityFrameworkCore;
using MyApi.Core.Entities;
using MyApi.Core.Interfaces;
using MyApi.Infranstructure.Data;

namespace MyApi.Infranstructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext dbContext;

        public EmployeeRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<EmployeeEntity>> GetEmployeesAsync()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<EmployeeEntity?> GetEmployeeByIdAsync(Guid id)
        {
            return await dbContext.Employees.FindAsync(id);
        }

        public async Task<EmployeeEntity?> AddEmployeeAsync(EmployeeEntity entity)
        {
            entity.Id = Guid.NewGuid();
            dbContext.Employees.Add(entity);

            await dbContext.SaveChangesAsync(); 

            return entity;
        }

        public async Task<EmployeeEntity?> UpdateEmployeeAsync(Guid employeeId,EmployeeEntity entity)
        {
            var employee = dbContext.Employees.Find(employeeId);

            if(employee != null)
            {
                employee.Name = entity.Name;
                employee.Phone = entity.Phone;
                employee.Email = entity.Email;

                await dbContext.SaveChangesAsync();

                return employee;
            }

            return entity;
        }

        public async Task<bool> DeleteEmployeeAsync(Guid employeeId)
        {
            var employee = dbContext.Employees.Find(employeeId);
            
            if (employee != null)
            {
                dbContext.Employees.Remove(employee);
                await dbContext.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
