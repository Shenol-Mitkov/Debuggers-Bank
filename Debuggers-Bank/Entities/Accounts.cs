using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Debuggers_Bank.Entities
{
    internal partial class Accounts
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

       


    }
}
