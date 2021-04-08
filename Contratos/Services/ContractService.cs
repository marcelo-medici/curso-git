using System;
using Course.Contratos.Entities;

namespace Course.Contratos.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double amount = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);                
                double amount1 = _onlinePaymentService.Interest(amount, i);
                amount1 = _onlinePaymentService.PaymentFee(amount1);
                contract.AddInstallment(new Installment(date, amount1));
            }
        }
    }
}