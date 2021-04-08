using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Exception1.Entities.Exception;

namespace Course.Exception1.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimt { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimt)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimt = withDrawLimt;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimt)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }


    }
}
