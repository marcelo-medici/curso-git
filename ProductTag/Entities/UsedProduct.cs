using System;
using System.Globalization;

namespace ProductTag.Entities
{
    class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct(string name, double price, DateTime date)
            :base(name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return base.PriceTag()
                + " (Manufacture date: "
                + Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
