using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Debuggers_Bank.Entities
{
    internal partial class Accounts
    {
        public static void CreateAccount()
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
        public static void ShowAccounts()
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


        public static void TransferMoney()

        {
            if (UserAccounts.Count < 2)
            {
                Console.WriteLine("At least two accounts are required for a transfer.");
                return;
            }

            ShowAccounts();

            Console.Write("Enter the account ID from which to transfer: ");
            if (!int.TryParse(Console.ReadLine(), out int sourceId))
            {
                Console.WriteLine("Invalid source account ID.");
                return;
            }

            Console.Write("Enter the destination account ID: ");
            if (!int.TryParse(Console.ReadLine(), out int destinationId))
            {
                Console.WriteLine("Invalid destination account ID.");
                return;
            }

            Accounts? source = UserAccounts.Find(account => account._id == sourceId);
            Accounts? destination = UserAccounts.Find(account => account._id == destinationId);

            if (source is null)
            {
                Console.WriteLine("The source account could not be found.");
                return;
            }

            if (destination is null)
            {
                Console.WriteLine("The destination account could not be found.");
                return;
            }

            if (source == destination)
            {
                Console.WriteLine("The source and destination accounts must be different.");
                return;
            }

            Console.Write("Enter an amount to transfer: ");
            if (!double.TryParse(
                    Console.ReadLine(),
                    NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite,
                    CultureInfo.InvariantCulture,
                    out double amount) ||
                amount <= 0 ||
                double.IsNaN(amount) ||
                double.IsInfinity(amount))
            {
                Console.WriteLine("Enter a valid positive transfer amount.");
                return;
            }

            if (source._accountBalance < amount)
            {
                Console.WriteLine("Insufficient balance in the source account.");
                return;
            }

            source._accountBalance -= amount;
            destination._accountBalance += amount;

            Console.WriteLine(
                $"Successfully transferred {amount.ToString("F2", CultureInfo.InvariantCulture)} Kr " +
                $"from account {sourceId} to account {destinationId}.");
        }
    }
}
