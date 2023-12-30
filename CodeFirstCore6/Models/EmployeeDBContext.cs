using Microsoft.EntityFrameworkCore;

namespace CodeFirstCore6.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }  
    }
}
