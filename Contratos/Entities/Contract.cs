using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Contratos.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; private set; } 

        public Contract(int number, DateTime date, double contractValue)
        {
            Number = number;
            Date = date;
            TotalValue = contractValue;
            Installments= new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Installment installment in Installments)
            {
                sb.AppendLine(installment.ToString());
            }
            return sb.ToString();
        }


    }
}
