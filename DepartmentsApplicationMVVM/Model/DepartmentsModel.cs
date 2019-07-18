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
        public readonly ObservableCollection<Department> pDepartmentList;
        //public readonly ObservableCollection<Employee> pEmployeeList;


        public DepartmentsModel()
        {
            DbContext = new DepartmentsDbContext();
            DbContext.Employees.Load();
            DbContext.Departments.Load();

            pDepartmentList = DbContext.Set<Department>().Local;
            //pEmployeeList = DbContext.Set<Employee>().Local;
        }

        public void AddDepartment(Department dep)
        {
            DbContext.Set<Department>().Add(dep);
            DbContext.SaveChanges();
            RaisePropertyChanged("pDepartmentList");
        }

        //public void AddEmployee(Employee emp)
        //{
        //    DbContext.Set<Employee>().Add(emp);
        //    DbContext.SaveChanges();
        //    RaisePropertyChanged("pEmployeeList");
        //}
    }
}
