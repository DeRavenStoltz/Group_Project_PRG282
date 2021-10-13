using System.Collections.Generic;

namespace Group_Project_PRG282.DataAccesLayer
{
    public class User
    {
        private string _username;
        private string _password;

        public User()
        {
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        public static List<User> LoggedInUser { get; set; } = new List<User>();
    }
}