using System;

namespace Matrix2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] length = Console.ReadLine().Split(" ");

            int x = int.Parse(length[0]);
            int y = int.Parse(length[1]);


            int[,] mat = new int[x, y];



            for (int i = 0; i < x ; i++)
            {
                string[] line = Console.ReadLine().Split(" ");

                for (int j = 0; j < y; j++)
                {
                    mat[i, j] = int.Parse( line[j] );

                }
            }

            int valor = int.Parse(Console.ReadLine());


            for (int i = 0; i < x; i++)
            {
                
                for (int j = 0; j < y; j++)
                {
                    if (mat[i, j] == valor)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if ((j - 1) >= 0) Console.WriteLine("Left: " + mat[i,j-1]);
                        if ((j + 1) < y) Console.WriteLine("Right: " + mat[i, j+1]);
                        if ((i - 1) >= 0) Console.WriteLine("Up: " + mat[i-1, j]);
                        if ((i + 1) < x) Console.WriteLine("Down: " + mat[i+1, j]);
                        Console.WriteLine();
                    }  
                }
            }


            



        }
    }
}
