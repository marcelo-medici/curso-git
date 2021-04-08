using System;
using System.IO;

namespace Course.Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Matrix matrix = new Matrix(n);
            matrix.BuildMatrix();
            matrix.MainDiagonal();
            matrix.NegativeNumbers();

            Console.WriteLine(Path.GetTempFileName());
        }
    }
}
