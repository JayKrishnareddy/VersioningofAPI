using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Versioning.Model
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options):base(options) 
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
