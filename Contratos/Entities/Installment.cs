using System;
using System.Globalization;

namespace Course.Contratos.Entities
{
    public class Installment
    {
        public DateTime Date { get; set; }
        public double Amount { get; private set; }

        public Installment(DateTime date, double value)
        {
            Date = date;
            Amount = value;
        }

        public override string ToString()
        {
            return Date.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}