using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Debuggers_Bank.Entities
{
    internal partial class Accounts
    {
        private static readonly List<Accounts> UserAccounts = new List<Accounts>();

        static Accounts()
        {
            new Accounts("Main account", 1000, 1);
            new Accounts("Travel Account", 2500, 2);
        }

        private readonly int _id;
        private double _accountBalance;

        public string AccountName { get; set; }

        public Accounts(string accountname, double accountbalance, int id)
        {
            AccountName = accountname;
            _accountBalance = accountbalance;
            _id = id;
            UserAccounts.Add(this);
        }


        private sealed record Transaction(DateTimeOffset Timestamp, int FromAccountId, string FromAccountName, int ToAccountId, string ToAccountName, double Amount);

        private static readonly List<Transaction> TransactionHistory = new List<Transaction>();



    }
}
