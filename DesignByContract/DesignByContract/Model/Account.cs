using DesignByContract.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignByContract.Model
{
    public class Account : IfAccount
    {
        private double _balance;
        public double balance { get { return _balance; } }
        public Account() : this(0.00d)
        {

        }
        public Account(double amount)
        {
            _balance = amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
    }
}
