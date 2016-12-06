using System;
using System.Diagnostics.Contracts;

namespace DesignByContract.Contracts
{
    [ContractClassFor(typeof(IfAccount))]
    public abstract class AccountContract : IfAccount
    {
       

        public double balance { get; }
        public void Deposit(double amount)
        {
            Contract.Requires<ArgumentOutOfRangeException>(amount > 0,"amount should always be positive");
            //balance += amount;
            //throw new NotImplementedException();
        }

        public void Withdraw(double amount)
        {
            Contract.Requires<ArgumentOutOfRangeException>(amount > 0, "amount should always be positive");
            Contract.Requires<ArgumentOutOfRangeException>(balance>amount, "Exception amount is greater than the balance!!");
            //balance -= amount;
            
            //throw new NotImplementedException();
        }
    }
}