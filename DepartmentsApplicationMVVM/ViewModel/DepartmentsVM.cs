using DepartmentsApplicationMVVM.Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DepartmentsApplicationMVVM.ViewModel
{
    public class DepartmentsVM : BindableBase
    {
        readonly DepartmentsModel _model = new DepartmentsModel();

        public DelegateCommand<string> AddDepartmentCommand { get; }
        public DelegateCommand<Employee> AddEmployeeCommand { get; }
        public ObservableCollection<Department> pDepartmentList => _model.pDepartmentList;
        //public ObservableCollection<Employee> pEmployeeList => _model.pEmployeeList;
        public DepartmentsVM()
        {
            _model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };

            AddDepartmentCommand = new DelegateCommand<string>(name => _model.AddDepartment(new Department(name)));
            //AddEmployeeCommand = new DelegateCommand<Employee>(emp  => _model.AddEmployee(emp));
            
        }


    }
}
