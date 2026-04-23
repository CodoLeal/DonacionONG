using System;
using System.Collections.Generic;
using System.Text;

namespace DonacionONG.model
{
    internal class User
    {
        private String Username;
        private String Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
    }


    
}
