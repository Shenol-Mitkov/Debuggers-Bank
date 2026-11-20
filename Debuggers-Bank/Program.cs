using Debuggers_Bank.Entities;
using Debuggers_Bank.Services;

namespace Debuggers_Bank
{
    internal class Program
    {
        static void Main()
        {
            AdminService adminService = new AdminService();

            adminService.CreateUser("Farid", "12345");
            adminService.CreateUser("Farid", "33334");

            Accounts account = new Accounts("Savings Account", 1000, 1);
            
            account.ShowAccounts();
            account.CreateAccount();
            account.ShowAccounts(); 

            Console.ReadLine();
        }
    }
}
