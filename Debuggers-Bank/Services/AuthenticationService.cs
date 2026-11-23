using System.Collections.Generic;
using Debuggers_Bank.Entities;

namespace Debuggers_Bank.Services
{
    internal class AuthenticationService
    {
        private List<User> users;

        public AuthenticationService(List<User> userList)
        {
            users = userList;
        }

        public User? FindUser(string username)
        {
            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    return user;
                }
                
            }
            return null;
        }


        public bool Login(string username, string password)
        {
            User user = FindUser(username);
            if (user == null)
            {
                return false;
            }
            return true;
        }
    }
}
