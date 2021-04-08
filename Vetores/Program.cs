using System;
using Course.Vetores.Entities;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            const int totalQuartos = 10;
            Estudante[] quartos = new Estudante[totalQuartos];
            Console.Write("Quantos quartos serão alugados? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i+1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int n = int.Parse(Console.ReadLine());
                quartos[n] = new Estudante { Nome = nome, Email = email };
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < totalQuartos; i++)
            {
                if (quartos[i] != null)
                {
                    Console.Write(i + ": " + quartos[i].Nome + ", " + quartos[i].Email);
                    Console.WriteLine();
                }
            }

            

        }
    }
}
