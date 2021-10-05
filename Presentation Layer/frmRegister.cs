using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Group_Project_PRG282.Data_Access_Layer;
using Group_Project_PRG282.BusinessLogicLayer;

namespace Group_Project_PRG282
{
    public partial class Register : Form
    {
        FileHandler db = new FileHandler();
        RegisterUser ru = new RegisterUser();
        List<string> existingUsers = new List<string>();


        public Register()
        {
            InitializeComponent();
            existingUsers = db.getUsers();

        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadLogin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string newUser = ru.addUser(txtUserName.Text, txtPassword.Text);
            existingUsers.Add(newUser);
            db.addUser(existingUsers);
            loadLogin(); 
        }

        public void loadLogin()
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            Close();
        }
    }
}
