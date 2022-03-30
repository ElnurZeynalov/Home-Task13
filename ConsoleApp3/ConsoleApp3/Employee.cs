using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Employee
    {
        private int _id;
        public int Id { get { return _id; } }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee(string name, int salary)
        {
            _id++;
            Name = name;
            Salary = salary;
        }
        public string ShowInfo()
        {
            return $"Id: {this.Id} Name: {this.Name} - Salary: {this.Salary}";
        }
    }
}
