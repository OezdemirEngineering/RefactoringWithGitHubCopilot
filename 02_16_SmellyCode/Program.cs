using System;
using System.Collections.Generic;
using System.Linq;

namespace SmellyProject
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeService employeeService = new EmployeeService();

            employeeService.AddEmployee("Alice", 1, 1000, "A", 1);
            employeeService.AddEmployee("Bob", 2, 800, "B", 2);
            employeeService.AddEmployee("Charlie", 3, 900, "C", 3);

            employeeService.DisplayEmployeeData();
        }
    }

    class EmployeeService
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(string name, int type, double baseSalary, string departmentCode, int employeeId)
        {

            Employee employee;
            switch (type)
            {
                case 1:
                    employee = new Manager(name, baseSalary, departmentCode, employeeId);
                    break;
                case 2:
                    employee = new Developer(name, baseSalary, departmentCode, employeeId);
                    break;
                case 3:
                    employee = new Intern(name, baseSalary, departmentCode, employeeId);
                    break;
                default:
                    Console.WriteLine("Unknown employee type.");
                    return;
            }
            employees.Add(employee);
        }

        public void DisplayEmployeeData()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Role: {employee.Role}, Department: {employee.DepartmentCode}, Salary: {employee.BaseSalary}");

                if (employee is Developer developer)
                {
                    Console.WriteLine($"Developer Level: {developer.DevLevel}");
                }
                else if (employee is Manager manager)
                {
                    Console.WriteLine("Manager Privileges: Can approve budgets.");
                }
                else if (employee is Intern intern)
                {
                    Console.WriteLine("Intern Privileges: Limited access.");
                }
                Console.WriteLine("-----------------------------");
            }
        }
    }

    abstract class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public double BaseSalary { get; set; }
        public string DepartmentCode { get; set; }
        public int EmployeeId { get; set; }

        public void CalculateBonus()
        {
            if (Role == "Manager")
            {
                Console.WriteLine($"Manager Bonus: {BaseSalary * 0.2}");
            }
            else if (Role == "Developer")
            {
                Console.WriteLine($"Developer Bonus: {BaseSalary * 0.1}");
            }
            else if (Role == "Intern")
            {
                Console.WriteLine("Interns do not receive a bonus.");
            }
        }
    }

    class Manager : Employee
    {
        public Manager(string name, double baseSalary, string departmentCode, int employeeId)
        {
            Name = name;
            Role = "Manager";
            BaseSalary = baseSalary;
            DepartmentCode = departmentCode;
            EmployeeId = employeeId;
        }
    }

    class Developer : Employee
    {
        public int DevLevel { get; set; }

        public Developer(string name, double baseSalary, string departmentCode, int employeeId)
        {
            Name = name;
            Role = "Developer";
            BaseSalary = baseSalary;
            DepartmentCode = departmentCode;
            EmployeeId = employeeId;
            DevLevel = 2; 
        }


        public void Code()
        {
            Console.WriteLine("Developer is coding...");
            if (DevLevel > 1)
            {
                Console.WriteLine("Developer has advanced privileges.");
            }
        }
    }


    class Intern : Employee
    {
        public Intern(string name, double baseSalary, string departmentCode, int employeeId)
        {
            Name = name;
            Role = "Intern";
            BaseSalary = baseSalary;
            DepartmentCode = departmentCode;
            EmployeeId = employeeId;
        }
    }


    class BonusCalculator
    {
        public double CalculateAnnualBonus(Employee employee)
        {
            if (employee.Role == "Manager")
            {
                return employee.BaseSalary * 0.25;
            }
            else if (employee.Role == "Developer")
            {
                return employee.BaseSalary * 0.15;
            }
            else
            {
                return 0;
            }
        }


        public void PrintAnnualBonus()
        {
            Console.WriteLine("Annual bonus calculated.");
        }
    }


    class EmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();


        public List<Employee> GetEmployeesByDepartment(string departmentCode)
        {
            return employees.Where(e => e.DepartmentCode == departmentCode).ToList();
        }
    }
}
