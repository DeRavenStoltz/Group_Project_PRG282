using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Group_Project_PRG282.PresentationLayer
{
    public partial class frmModules : Form
    {
        private BindingSource source = new BindingSource();
        private DataHandler dh = new DataHandler();
        private List<Module> lmodule = new List<Module>();
        private DatabaseOperations operations = new DatabaseOperations();

        public frmModules(string currentUser)
        {
            InitializeComponent();
            lblWelcomeUser.Text = $"{User.LoggedInUser[0].Username}";
        }

        public frmModules()
        {
            InitializeComponent();
            lblWelcomeUser.Text = $"{User.LoggedInUser[0].Username}";
        }

        private void frmModules_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult userResult = MessageBox.Show("Are you sure you want to switch users?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (userResult == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            source.DataSource = dh.GetModules(dh.ConnectDatabase());
            dgvModules.DataSource = source;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmAddModule add = new frmAddModule(this);
            add.moduleAdded += loadDataGrid;
            add.Show();
            Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            source.DataSource = operations.SearchModule(lmodule, txtsearchBox.Text);
            dgvModules.DataSource = source;
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            source.MoveLast();
        }

        private void buttonMoveNext_Click(object sender, EventArgs e)
        {
            source.MoveNext();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            source.MovePrevious();
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            source.MoveFirst();
        }

        private void dgvModules_SelectionChanged(object sender, EventArgs e)
        {
            Module mod = source.Current as Module;
            if (mod != null)
            {
                lblModuleCode.Text = mod.ModuleID;
                lblModuleDescription.Text = mod.ModuleDescription;
                lblModuleName.Text = mod.ModuleName;
                lblLink.Text = mod.ModuleLink;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Module mod = source.Current as Module;
            if (mod != null)
            {
                operations.deleteModule(dh.ConnectDatabase(), mod.ModuleID, mod.ModuleName);
            }
            source.ResetBindings(true);
            loadDataGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateModules frmUpdate = new frmUpdateModules(this, lblModuleCode.Text, lblModuleName.Text, lblModuleDescription.Text, lblLink.Text);
            frmUpdate.updateSuccess += loadDataGrid;
            frmUpdate.Show();
            Hide();
        }

        public void loadDataGrid()
        {
            dgvModules.DataSource = null;
            lmodule = dh.GetModules(dh.ConnectDatabase());
            source.DataSource = lmodule;
            dgvModules.DataSource = source;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmNavigation frmNav = new frmNavigation();
            frmNav.Show();
            Close();
        }
    }
}