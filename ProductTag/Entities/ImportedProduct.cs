using System.Globalization;

namespace ProductTag.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double customFee)
            :base(name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return base.Name
                + " R$"
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Custom fee R$"
                + CustomFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

        public double TotalPrice() {
            return base.Price + CustomFee;
        }
    }
}
