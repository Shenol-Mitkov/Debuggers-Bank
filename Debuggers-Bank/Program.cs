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

            adminService.CreateUser("user1", "test123");
            adminService.CreateUser("user2", "test456");
            adminService.CreateUser("user3", "test789");

            

            Menu DebuggersBank = new Menu(users);

            DebuggersBank.ShowMenu();





        }
    }
}
