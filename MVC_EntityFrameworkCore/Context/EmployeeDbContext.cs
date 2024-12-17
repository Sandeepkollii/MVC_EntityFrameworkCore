using Microsoft.EntityFrameworkCore;
using MVC_EntityFrameworkCore.Models;

namespace MVC_EntityFrameworkCore.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(){

            }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> dbContextOptionsBuilder)
           : base(dbContextOptionsBuilder) { }
        public DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SANDEEP\\SQLEXPRESS;Database=Employee;Trusted_Connection=True;TrustServerCertificate=true");


        }
    }
}
