using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer;
using Group_Project_PRG282.Presentation_Layer;
using Group_Project_PRG282.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Group_Project_PRG282
{
    public partial class frmLogin : Form
    {
        private FileHandler db = new FileHandler();
        private ComponentController cc = new ComponentController();
        private CheckLogin cl = new CheckLogin();
        private List<string> usersInSystem = new List<string>();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            cl.checkLogin(txtusernameBoxLogin.Text, txtpasswordBoxLogin.Text, usersInSystem);
        }
        private void btnClearLogin_Click(object sender, EventArgs e)
        {
            cc.clearFieldsLogIn(txtusernameBoxLogin, txtpasswordBoxLogin);
        }
        public void loginSuccessful()
        {
            frmNavigation navigation = new frmNavigation();
            cc.clearFieldsLogIn(txtusernameBoxLogin, txtpasswordBoxLogin);
            navigation.Show();
            Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtusernameBoxLogin.Focus();
            cl.loginSuccess += loginSuccessful;
            usersInSystem = db.getUsers();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void passwordPicture_MouseDown(object sender, MouseEventArgs e)
        {
            txtpasswordBoxLogin.UseSystemPasswordChar = false;
        }
        private void passwordPicture_MouseUp(object sender, MouseEventArgs e)
        {
            txtpasswordBoxLogin.UseSystemPasswordChar = true;
        }
    }
}