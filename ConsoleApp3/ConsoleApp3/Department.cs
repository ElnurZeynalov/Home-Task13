using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Department
    {
        public int EmployeeLimit { get; set; }
        private Employee[] _employees;
        public Department(int employeeLimit)
        {
            EmployeeLimit=employeeLimit;
            _employees=new Employee[0]; 
        }
        public void AddEmployee(Employee employee)
        {
            if (_employees.Length<EmployeeLimit)
            {
                Array.Resize(ref _employees, _employees.Length+1);
                _employees[_employees.Length-1] = employee;
                return;
            }
            throw new LimitException("Limit Doldu");
        }
        public Employee GetEmployeById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("Bele bir Id movcud deyil");
            foreach (var item in _employees)
            {
                if(item.Id == id)
                    return item;
            }
            return null;
        }
        public Employee[] GetEmployees()
        {
            return _employees;
        }
    }
}
