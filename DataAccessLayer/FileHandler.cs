using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Group_Project_PRG282.DataAccesLayer
{
    internal class FileHandler
    {
        public FileHandler()
        {
        }

        private string users = $"{AppContext.BaseDirectory}Users.txt";

        public List<string> getUsers()
        {
            FileStream Stream = new FileStream(users, FileMode.OpenOrCreate);
            List<string> usernames = new List<string>();
            try
            {
                string text;
                using (StreamReader reader = new StreamReader(Stream, Encoding.UTF8))
                {
                    while ((text = reader.ReadLine()) != null)
                    {
                        usernames.Add(text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return usernames;
        }

        public void addUser(List<string> newUser)
        {
            File.WriteAllLines(users, newUser);
        }
    }
}