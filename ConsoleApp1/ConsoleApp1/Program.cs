using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Elovset";
            employee1.Lastname = "Dasdemirov";
            try
            {
            employee1.Age = 58;
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                employee1.Salary = 200;
            }
            catch (SalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                employee1.WorkTime = 9;
            }
            catch (WorkTimeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
