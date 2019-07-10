using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentsApplicationMVVM.Model
{
    class Model
    {
        DepartmentsDbContext DbContext;

        public ObservableCollection<Department> DepartmentList;
        public ObservableCollection<Employee> EmployeeList;

        public Model()
        {
            DbContext = new DepartmentsDbContext();
            DbContext.Employees.Load();
            DbContext.Departments.Load();
            DepartmentList = DbContext.Set<Department>().Local;
            EmployeeList = DbContext.Set<Employee>().Local;
        }
    }
}
