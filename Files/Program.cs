using System.Globalization;
using System.Collections.Generic;
using System.IO;
using Course.Files.Entities;
using System;


namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"C:\Projetos\C#\Course\Files\Products.txt";
            string targetFolderPath = Path.GetDirectoryName(sourceFilePath) + @"\Out\";
            string targetFilePath = targetFolderPath + Path.GetFileNameWithoutExtension(sourceFilePath) + ".csv";


            List<Product> products = new List<Product>();

            try
            {
                using (StreamReader sr = File.OpenText(sourceFilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(",");
                        products.Add(new Product(
                            fields[0]
                            , double.Parse(fields[1], CultureInfo.InvariantCulture)
                            , int.Parse(fields[2])));
                    }
                }

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (Product product in products)
                    {
                        Console.WriteLine(product.SummaryTxt());
                        sw.WriteLine(product.SummaryTxt());
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error Occurred: " + e.Message);
            }
        }
    }
}
