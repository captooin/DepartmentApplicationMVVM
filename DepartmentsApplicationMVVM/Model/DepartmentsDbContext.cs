using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentsApplicationMVVM.Model
{
    class DepartmentsDbContext : DbContext
    {
        public DepartmentsDbContext() : base(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=db; Integrated Security=True") { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
