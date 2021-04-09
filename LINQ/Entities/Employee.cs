using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string email { get; set; }
        public double salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            this.email = email;
            this.salary = salary;
        }
    }
}
