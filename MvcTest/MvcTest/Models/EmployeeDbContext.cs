using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("name=MvcTestDb")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}