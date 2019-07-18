using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentsApplicationMVVM.Model
{
    public class Department
    {
        public Department() { }
        public Department(string name)
        {
            Name = name;
        }

        public int DepartmentId { get; set; }

        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public virtual ObservableCollection<Employee> Employees { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
