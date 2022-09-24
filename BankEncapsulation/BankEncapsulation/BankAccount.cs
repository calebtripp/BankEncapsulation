using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double balance = 0;
        public double GetBalance()
        {
            return balance;
        }
        public void Deposit(double toDeposit)
        {
            balance += toDeposit;
        }
        public void Withdrawal(double toWithdraw)
        {
            balance -= toWithdraw;
        }
    }
}
