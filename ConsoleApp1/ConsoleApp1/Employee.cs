using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Employee
    {
        private int _age;
        private int _salary;
        private int _workTime;
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age 
        { 
            get=>_age; 
            set
            {
                if(value>17 && value<55)
                {
                    _age = value;
                    return;
                }
                throw new AgeException("Yas 17 den boyuk 55 den kicik olmalidir ");

            }
        }
        public int Salary 
        { 
            get=>_salary;
            set
            {
                if(value>=350)
                {
                    _salary = value;
                    return ;
                }
                throw new SalaryException("Maas 350 Azn veya cox olamlidir");
            }
        }
        public int WorkTime
        {
            get => _workTime;
            set
            {
                if(value<9)
                {
                    _workTime = value;
                    return;
                }
                throw new WorkTimeException("Is saati maksimum 8 veya 8 den az olamlidir");
            }
        }


    }
}
