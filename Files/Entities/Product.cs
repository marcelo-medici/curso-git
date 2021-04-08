using System;
using System.Globalization;
using Course.Files;


namespace Course.Files.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qtd { get; set; }

        public Product(string name, double price, int qtd)
        {
            Name = name;
            Price = price;
            Qtd = qtd;
        }
        
        public string SummaryTxt()
        {
            return Name + ", " + (Price * (double)Qtd).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
