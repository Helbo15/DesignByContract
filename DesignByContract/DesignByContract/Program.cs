using DesignByContract.Model;
using DesignByContract.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignByContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Account anAccount = new Account();
            Account aSecondAccount = new Account(300.0d);
            Console.WriteLine("anAccount: deposit 200:");
            anAccount.Deposit(200);
            Console.WriteLine("anAccount: Withdraw 100:");
            anAccount.Withdraw(100);

            Console.WriteLine("aSecondAccount: deposit 200:");
            aSecondAccount.Deposit(200);
            //expect the rest of this to throw uncatchable
            //exceptions as the Account Class is not designed for this kind of usage
            try
            {

                Console.WriteLine("aSecondAccount:Deposit -200:");
                aSecondAccount.Deposit(-200);
            }
            catch (Exception ex)
            {
                Console.WriteLine("could not deposit -200 from aSecondAccount because: {0}", ex.Message);
            }

            try
            {
                Console.WriteLine("anAccount: Withdraw 200:");
                anAccount.Withdraw(200);
            }
            catch(Exception ex)
            {
                Console.WriteLine("could not withdraw 200 from anAccount because: {0}", ex.Message);
            }
            try
            {

                Console.WriteLine("aSecondAccount:Withdraw -200:");
                aSecondAccount.Withdraw(-200);
            }
            catch (Exception ex)
            {
                Console.WriteLine("could not withdraw -200 from aSecondAccount because: {0}", ex.Message);
            }
           
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}
