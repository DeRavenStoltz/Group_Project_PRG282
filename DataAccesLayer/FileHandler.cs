using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Group_Project_PRG282.DataAccesLayer
{
    class FileHandler
    {
        public FileHandler()
        {

        }

        string users = $"{AppContext.BaseDirectory}Users.txt";

        public List<string> getUsers()
        {
            List<string> usernames = File.ReadAllLines(users).ToList();

            return usernames;
        }

        public void addUser(List<string> newUser)
        {
            File.WriteAllLines(users, newUser);
        }
    }
}
