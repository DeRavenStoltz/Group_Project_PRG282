using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Group_Project_PRG282
{
    public partial class Register : Form
    {
        private FileHandler db = new FileHandler();
        private RegisterUser ru = new RegisterUser();
        private List<string> existingUsers = new List<string>();

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

        private void txtFocus_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            var parent = textBox.Parent;

            textBox.BackColor = Color.White;
            parent.BackColor = Color.White;
        }

        private void txtFocus_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            var parent = textBox.Parent;

            textBox.BackColor = SystemColors.Control;
            parent.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}