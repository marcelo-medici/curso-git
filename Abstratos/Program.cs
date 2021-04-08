using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Abstratos.Entities;


namespace Course.Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthSpending));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employeeQdt = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, employeeQdt));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double total = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                double tax = taxPayer.TaxCalculation();
                Console.WriteLine(taxPayer.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                total += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + total.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
