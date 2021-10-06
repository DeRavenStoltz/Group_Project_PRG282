using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer; 

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
            showLogin(); 
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string newUser = ru.addUser(txtUsername.Text, txtPassword.Text);
            existingUsers.Add(newUser);
            db.addUser(existingUsers);
            clearFields(); 
            showLogin(); 
        }

        private void btnClearLogin_Click(object sender, EventArgs e)
        {
            clearFields(); 
        }

        public void clearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear(); 
        }

        public void showLogin()
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            Close();
        }
    }
}
