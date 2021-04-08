using System;
using System.Globalization;
using Course.Contratos.Entities;
using Course.Contratos.Services;

namespace Contratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contrato = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PaypalService());


            Console.Write("Enter number of installments: ");
            try
            {
                contractService.ProcessContract(contrato, int.Parse(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.WriteLine("Installments");
            Console.WriteLine(contrato);



        }
    }
}
