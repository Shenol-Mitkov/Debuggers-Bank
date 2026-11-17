using Debuggers_Bank.Entities;

namespace Debuggers_Bank
{
    internal class Program
    {
        static void Main()
        {
            Accounts account1 = new Accounts("Savings Account", 1000, 1);
            account1.CreateAccount();
            account1.ShowAccounts();

            Console.ReadLine();
        }
    }
}
