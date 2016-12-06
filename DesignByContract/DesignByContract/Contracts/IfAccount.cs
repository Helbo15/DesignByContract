using System.Diagnostics.Contracts;

namespace DesignByContract.Contracts
{
    [ContractClass(typeof(AccountContract))]
    public interface IfAccount
    {
        double balance { get; }
        void Deposit(double amount);
        void Withdraw(double amount);   
    }
}
