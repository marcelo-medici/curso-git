using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Matrizes;

namespace Course.Matrizes
{
    class Matrix
    {
        public int N { get; set; }
        public int[,] Mat { get; set; }

        public Matrix(int n)
        {
            N = n;
            Mat = new int[n, n];
        }

        public void BuildMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                int j = 0;
                foreach (string element in Console.ReadLine().Split(" "))
                {
                    Mat[i, j++] = int.Parse(element);
                }
            }
        }

        public void MainDiagonal() {

            Console.WriteLine();
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(Mat[i, i] + " ");
            }
            Console.WriteLine();
        }

        public void NegativeNumbers()
        {
            Console.Write("Negative numbers = ");
            int nNeg = 0;
            foreach (int element in Mat)
            {
                if (element < 0) nNeg++;
            }
            Console.WriteLine(nNeg);
        }


    }
}
