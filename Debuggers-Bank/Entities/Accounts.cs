using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Debuggers_Bank.Entities
{
    internal class Accounts
    {
       

        //Function to display the details of all accounts
        public void ShowAccounts()
        {
            if (UserAccounts.Count == 0)
            {
                Console.WriteLine("No accounts have been created.");
                return;
            }

            foreach (Accounts account in UserAccounts)
            {
                Console.WriteLine($"Account Name: {account.AccountName}");
                Console.WriteLine($"Account Balance: {account._accountBalance.ToString("F2", CultureInfo.InvariantCulture)} Kr");
                Console.WriteLine($"Account ID: {account._id}");
                Console.WriteLine();
            }
        }



    }
}
