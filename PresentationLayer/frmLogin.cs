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
using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer;
using Group_Project_PRG282.PresentationLayer;
using Group_Project_PRG282.Presentation_Layer;

namespace Group_Project_PRG282
{
    public partial class frmLogin : Form
    {
        FileHandler db = new FileHandler();
        ComponentController cc = new ComponentController();
        CheckLogin cl = new CheckLogin();
        List<string> usersInSystem = new List<string>();

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
            cc.clearFieldsLogIn(txtusernameBoxLogin,txtpasswordBoxLogin); 
        }


        public void loginSuccessful()
        {
            //frmMain main = new frmMain(txtusernameBoxLogin.Text);
            frmNavigation navigation = new frmNavigation(txtusernameBoxLogin.Text);
            cc.clearFieldsLogIn(txtusernameBoxLogin,txtpasswordBoxLogin);
            navigation.Show();
            Hide();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            cl.loginSuccess += loginSuccessful;
            usersInSystem = db.getUsers();
        }
    }
}
