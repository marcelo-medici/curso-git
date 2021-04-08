using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Contratos.Services;

namespace Course.Contratos.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double paymentFeeTax = 0.02;
        private const double interestTax = 0.01;
        
        public double PaymentFee(double amount)
        {
            return amount + amount * paymentFeeTax;
        }

        public double Interest(double amount, int months)
        {
            return amount + amount * interestTax * months;
        }

    }
}
