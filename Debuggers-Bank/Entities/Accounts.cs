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

        public void CreateAccount()
        {
            Console.Write("Would you like to create a new account? (y/n) ");
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N)
                {
                    Console.Write("Please press y or n: ");
                }
            }
            while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N);

            Console.WriteLine(keyInfo.KeyChar);
            if (keyInfo.Key == ConsoleKey.N)
            {
                return;
            }

            Console.Write("Enter the account name: ");
            string accountName = Console.ReadLine()?.Trim() ?? string.Empty;
            while (string.IsNullOrWhiteSpace(accountName))
            {
                Console.Write("Account name cannot be empty. Enter the account name: ");
                accountName = Console.ReadLine()?.Trim() ?? string.Empty;
            }

            double accountBalance;
            Console.Write("Enter the starting balance: ");
            while (!double.TryParse(
                       Console.ReadLine(),
                       NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite,
                       CultureInfo.InvariantCulture,
                       out accountBalance) ||
                   accountBalance < 0 || double.IsNaN(accountBalance) || double.IsInfinity(accountBalance))
            {
                Console.Write("Enter a valid non-negative balance: ");
            }

            int id = UserAccounts.Count + 1;
            new Accounts(accountName, accountBalance, id);
            Console.WriteLine("Account created successfully.");
            
            Console.WriteLine();
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
