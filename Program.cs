using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExerciciosAulas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp;

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>(n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Emplyoee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp = new Employee(id, name, salary);
                list.Add(emp);
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

