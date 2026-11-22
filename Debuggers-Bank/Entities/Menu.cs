using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Debuggers_Bank.Entities
{
    internal class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("Welcome to Debuggers Bank!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Create a new account");
            Console.WriteLine("2. Show all accounts");
            Console.WriteLine("3. Transfer money between accounts");
            Console.WriteLine("4. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    Accounts.CreateAccount();
                    
                    break;
                case "2":
                    Accounts.ShowAccounts();
                   
                    break;
                case "3":
                    Accounts.TransferMoney();
                    
                    break;
                case "4":
                    Console.WriteLine("Thank you for using Debuggers Bank!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    ShowMenu();
                    break;





            }
        }
    }
}
