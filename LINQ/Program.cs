using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using LINQ.Entities;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();


            using (StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    string[] fields = sr.ReadLine().Split(",");
                    foreach (var item in fields)
                    {
                        Console.Write(item + " ");
                        
                    }
                    Console.WriteLine();
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            }
            Console.Write("Enter salary: ");
            double minSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Email of peole whose salary is more than $" + minSalary);
            var search = employees.Where(emp => emp.salary > minSalary).OrderBy(emp => emp.email);

            foreach (var emp in search)
            {
                Console.WriteLine(emp.email);
            }

        }
    }
}
