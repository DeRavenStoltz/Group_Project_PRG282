using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

using Group_Project_PRG282.Presentation_Layer;
using Group_Project_PRG282.Data_Access_Layer;
using Group_Project_PRG282.BusinessLogicLayer;

namespace Group_Project_PRG282
{
    public partial class frmLogin : Form
    {

        FileHandler db = new FileHandler();
        CheckLogin cl = new CheckLogin();
        List<string> usersInSystem = new List<string>();

        public frmLogin()
        {
            InitializeComponent();
            usersInSystem = db.getUsers();
            cl.loginSuccess += loginSuccessful;
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cl.checkLogin(usernameBoxLogin.Text, passwordBoxLogin.Text, usersInSystem);   
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields(); 
        }

        public void clearFields()
        {
            usernameBoxLogin.Clear();
            passwordBoxLogin.Clear(); 
        }
        public void loginSuccessful()
        {
            frmMain main = new frmMain(usernameBoxLogin.Text);
            clearFields();
            main.Show();
            Hide();
        } 

    }
}
