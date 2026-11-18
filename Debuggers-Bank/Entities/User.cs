using System;
using System.Collections.Generic;
using System.Text;

namespace Debuggers_Bank.Entities
{
    internal class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int FailedLoginAttempts { get; set; }
        public bool IsLocked { get; set; }

        public User(string username, string passwordhash)
        {
            Username = username;
            PasswordHash = passwordhash;
            FailedLoginAttempts = 0;
            IsLocked = false;
        }


    }
}
