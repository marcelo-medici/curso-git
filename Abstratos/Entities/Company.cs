using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Abstratos.Entities;

namespace Course.Abstratos.Entities
{
    class Company : TaxPayer
    {
        public int EmployeeQdt { get; set; }

        public Company(string name, double anualIncome,int employeeQdt) : base(name, anualIncome)
        {
            EmployeeQdt = employeeQdt;
        }

        public override double TaxCalculation()
        {
            if (EmployeeQdt > 10)
            {
                return base.AnualIncome * 0.14;
            }
            return base.AnualIncome * 0.16;
        }
    }
}
