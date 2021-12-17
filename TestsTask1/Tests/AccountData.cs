using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    public class AccountData
    {
        public AccountData()
        {
        }

        public AccountData(string username, string password)
        {
            Username = username;
            Password = password;
        }


        public string Username { get; set; }

        public string Password { get; set; }

    }
}
