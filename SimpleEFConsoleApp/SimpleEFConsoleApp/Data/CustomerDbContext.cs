using Microsoft.EntityFrameworkCore;
using SimpleEFConsoleApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFConsoleApp.Data
{
    class CustomerDbContext:DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source = (localdb)\mssqllocaldb;
Initial Catalog = myemersondb;Integrated Security = True; TrustServerCertificate = True; MultipleActiveResultSets = true");
        }
    }
}
