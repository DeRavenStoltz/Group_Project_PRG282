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

namespace Group_Project_PRG282
{
    public partial class frmLogin : Form
    {
        SqlConnection connection;
        
        public frmLogin()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=(local); Initial Catalog=StudentSystem; Integrated Security=true");
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();

            if (usernameBoxLogin.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameBoxLogin.Focus();
                return;
            }
            if (passwordBoxLogin.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordBoxLogin.Focus();
                return;
            }

            bool flag = dh.UserLogin(usernameBoxLogin.Text, passwordBoxLogin.Text);

            if (flag == true)
            {
                MessageBox.Show("Succesfull. Please wait...", "Login Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(2000);
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed, please check details.", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameBoxLogin.Clear();
                passwordBoxLogin.Clear();
                usernameBoxLogin.Focus();
            }

            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
