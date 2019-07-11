using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentsApplicationMVVM.Model
{
    class DepartmentsModel : BindableBase
    {
        private readonly DepartmentsDbContext DbContext;
        public readonly DbSet<Department> pDepartmentSet;
        public readonly DbSet<Employee> pEmployeeSet;


        public DepartmentsModel()
        {
            DbContext = new DepartmentsDbContext();
            pDepartmentSet = DbContext.Set<Department>();
            pEmployeeSet = DbContext.Set<Employee>();
        }

    }
}
