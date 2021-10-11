﻿using System;
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

using Group_Project_PRG282.Presentation_Layer;

namespace Group_Project_PRG282.PresentationLayer
{
    public partial class frmNavigation : Form
    {
        string user;
        public frmNavigation(string username)
        {
            InitializeComponent();
            user = username;
        }
        public frmNavigation()
        {
            InitializeComponent();
            
        }
        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain(user);
            frm.Show();
            Hide();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            frmModules modules = new frmModules(user);
            modules.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmNavigation_Load(object sender, EventArgs e)
        {

        }
    }
}
