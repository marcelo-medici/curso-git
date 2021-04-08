using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Abstratos.Entities;

namespace Course.Abstratos.Entities
{
    class Individual : TaxPayer
    {        
        public double HealthSpending  { get; set; }

        public Individual (string name, double anualIncome, double healthSpending) : base(name, anualIncome)
        {
            HealthSpending = healthSpending;
        }

        override public double TaxCalculation()
        {
            double deduction = 0.0;
            if (base.AnualIncome < 20000.00)
            {
                deduction =  0.15;
            }
            else
            {
                deduction =  0.25;
            }

            return base.AnualIncome * deduction - HealthSpending * 0.5;
        }
    }
}
