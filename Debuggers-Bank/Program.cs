using Debuggers_Bank.Entities;

namespace Debuggers_Bank
{
    internal class Program
    {
        static void Main()
        {
            Accounts account = new Accounts("Savings Account", 1000, 1);
            
            account.ShowAccounts();
            account.CreateAccount();
            account.ShowAccounts();

            Console.ReadLine();
        }
    }
}
