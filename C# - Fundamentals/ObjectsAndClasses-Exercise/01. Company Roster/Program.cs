using System;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split();
                string name = args[0];
                double salary = double.Parse(args[1]);
                string department = args[2];
                Employee newEmployee = new Employee(name, salary, department);
                employees.Add(newEmployee);
            }

            var averaggeDepartSalary = employees.GroupBy(e => e.Department).Select(e => new
            {
                Department = e.Key,
                AvgSalary = e.Average(e => e.Salary)
            }).OrderByDescending(x => x.AvgSalary).FirstOrDefault();
            if (averaggeDepartSalary != null)
            {
                Console.WriteLine($"Highest Average Salary: {averaggeDepartSalary.Department}");
            }

            var highestPaidEmployee = employees.Where(x => x.Department == averaggeDepartSalary.Department)
                .OrderByDescending(e => e.Salary);
            foreach (var employee in highestPaidEmployee)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
      
    }

   
    public class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        
    }
}
