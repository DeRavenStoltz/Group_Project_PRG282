using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group_Project_PRG282.DataAccesLayer; 

namespace Group_Project_PRG282.BusinessLogicLayer
{
    class RegisterUser
    {
        User user = new User();
        public string addUser(string username, string password)
        {
            user.Username = username;
            user.Password = password;

            string newuser = $"{user.Username}, {user.Password}";

            return newuser;
        }
    }
}
