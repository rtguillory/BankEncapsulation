using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance;

        public void Deposit(double depositAmount)
        {
            _balance += depositAmount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
