using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t--Log in--");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            string password;
            do
            {
                Console.Write("Pasword: ");
                password = Console.ReadLine();
            } while (!password.PasswordChecker());
            int role;
            bool isNum;
            do
            {
                Console.Write("1.Admin\n2.Member\nWrite only 1 or 2: ");
                string role_choise = Console.ReadLine();
                isNum = int.TryParse(role_choise, out role);
            } while (!isNum || !Enum.IsDefined(typeof(Role), role));

            User user1 = new User(username, password, (Role)role);
            Console.Write("Employee Limit: ");
            int employelimit = Convert.ToInt32(Console.ReadLine());
            Department department = new Department(employelimit);
            bool checker = true;
            do
            {
                Console.WriteLine("\t----Menu----");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Get employe by id");
                Console.WriteLine("3. Get all employee");
                Console.WriteLine("4. Quit");
                string menu_choise = Console.ReadLine();
                switch (menu_choise)
                {
                    case "1":
                        if (user1.Role == Role.Admin)
                        {
                            try
                            {
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Salary: ");
                                int salary = Convert.ToInt32(Console.ReadLine());
                                Employee employee = new Employee(name, salary);
                                department.AddEmployee(employee);
                            }
                            catch (LimitException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else
                            Console.WriteLine("Sisteme isci eleva etmek uvun \"Admin\" statusunuz olamlidir!");
                        break;
                    case "2":
                        try
                        {
                            Console.Write("Axtarilacaq Id daxil edin: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            department.GetEmployeById(id).ShowInfo();
                        }
                        catch (NullReferenceException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        break;
                    case "3":
                        foreach (var item in department.GetEmployees())
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "4":
                        checker = false;
                        break;
                    default:
                        Console.WriteLine("Write only 1-4");
                        break;
                }
            } while (checker);
        }
    }
}
