using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Group_Project_PRG282.Data_Access_Layer
{
    class FileHandler
    {
        string users = $"{AppContext.BaseDirectory}Users.txt"; //Filepath to access file with usernames and passwords.

        public List<string> getUsers() //Reads text file and adds content to a list<string>.
        {
            List<string> usernames = File.ReadAllLines(users).ToList();

            return usernames;
        }

        public void addUser(List<string> newUser)//Recives List<string> with current users and newly addedd user. Content is then written to text file. 
        {
            File.WriteAllLines(users, newUser);
        }
    }
}
