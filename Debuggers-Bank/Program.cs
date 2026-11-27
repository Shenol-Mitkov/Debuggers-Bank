using System.Collections.Generic;
using Debuggers_Bank.Entities;
using Debuggers_Bank.Services;

namespace Debuggers_Bank
{
    internal class Program
    {
        static void Main()
        {
            List<User> users = new List<User>();
            AdminService adminService = new AdminService(users);
            AuthenticationService authenticationService = new AuthenticationService(users);

          

            Accounts account = new Accounts("Savings Account", 1000, 1);
            
            account.ShowAccounts();
            account.CreateAccount();
            account.ShowAccounts(); 

            Console.ReadLine();
        }
    }
}
