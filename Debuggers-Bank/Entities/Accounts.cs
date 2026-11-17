using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Debuggers_Bank.Entities
{
    internal class Accounts
    {
        private static readonly List<Accounts> UserAccounts = new List<Accounts>();

        private readonly int _id;
        private readonly double _accountBalance;

        public string AccountName { get; set; }

        public Accounts(string accountname, double accountbalance, int id)
        {
            AccountName = accountname;
            _accountBalance = accountbalance;
            _id = id;
            UserAccounts.Add(this);
        }

        

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
