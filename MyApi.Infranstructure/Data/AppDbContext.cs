using Microsoft.EntityFrameworkCore;
using MyApi.Core.Entities;

namespace MyApi.Infranstructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EmployeeEntity> Employees { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EmployeeEntity>().HasData(
        new EmployeeEntity
        {
            Id = Guid.Parse("a1111111-1111-1111-1111-111111111111"),
            Name = "Nguyễn Văn A",
            Email = "a@example.com",
            Phone = "0123456789"
        }
    );

        }
    }
}
