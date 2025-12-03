using EmployeeMvcDbApp.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMvcDbApp.Data
{
    public class EmployeeDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> providerOptions)
            :base(providerOptions) {
        
        }
        
        
    }
}
