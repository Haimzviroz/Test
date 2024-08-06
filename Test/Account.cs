using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Account
    {
        private protected double balance;
        double getBalance(double balance) { return balance; }
    }
    class SavingsAccount : Account
    {
        double SetBalance(double balance)
        {
            return balance;
        }
    }
}

