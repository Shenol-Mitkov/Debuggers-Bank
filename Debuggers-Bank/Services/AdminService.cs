using Debuggers_Bank.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Debuggers_Bank.Services
{
    internal class AdminService
    {
        private List<User> users = new List<User>(); 

        public bool UsernameExists(string username)
        {
            foreach(User user in users)
            {
                if(user.Username == username)
                {
                    return true;
                }
                
            }
            return false;
        }

        public void CreateUser(string username, string passwordhash)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Username cannot be empty!");
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordhash))
            {
                Console.WriteLine("Password cannot be empty!");
                return;
            }

            if(UsernameExists(username))
            {
                Console.WriteLine("Username already exists!");
                return;
            }
            User user = new User(username, passwordhash);
            users.Add(user);

            Console.WriteLine("User created successfully!");
        }
    }
}
