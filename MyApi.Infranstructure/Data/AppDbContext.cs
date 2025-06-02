using Microsoft.EntityFrameworkCore;
using MyApi.Core.Entities;

namespace MyApi.Infranstructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EmployeeEntity> Employees { get; set; } = null!;
    }
}
