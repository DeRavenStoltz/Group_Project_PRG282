﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project_PRG282.Data_Access_Layer
{
    class User
    {

        private string _username;
        private string _password;

        public User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
