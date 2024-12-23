using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EntityFramework
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() { 
        }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> dbContextOptionsBuilder)
           : base(dbContextOptionsBuilder) { }
        public DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SANDEEP\\SQLEXPRESS;Database=EmployeeEntity;Trusted_Connection=True;TrustServerCertificate=true");


        }
    }
}
