using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentsApplicationMVVM.Model
{
    public class Employee
    {
        public Employee() { }
        public Employee(string firstname, string lastname, int age, int salary, Department department)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Salary = salary;
        }
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
