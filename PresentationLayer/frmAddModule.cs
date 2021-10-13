using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer;
using System;
using System.Windows.Forms;

namespace Group_Project_PRG282.PresentationLayer
{
    public delegate void operationSuccess();

    public partial class frmAddModule : Form
    {
        public event operationSuccess moduleAdded;

        private DataHandler dh = new DataHandler();
        private DatabaseOperations op = new DatabaseOperations();
        private frmModules frm;

        public frmAddModule(frmModules frmmod)
        {
            InitializeComponent();
            frm = frmmod;
        }

        public frmAddModule()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmModules modules = new frmModules();
            modules.Show();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Validation v = new Validation();
            if (v.FinalValidate(txtModuleID.Text,txtModuleName.Text,txtModuleDescription.Text))
            {
                if (greenTick.Visible != true)
                {
                    MessageBox.Show("Invalid Link");
                }
                else
                if (op.InsertModules(dh.ConnectDatabase(), txtModuleID.Text, txtModuleName.Text, txtModuleDescription.Text, txtLink.Text))
                {
                    MessageBox.Show("Insert Completed");
                    if (moduleAdded != null)
                    {
                        moduleAdded();
                    }
                    txtModuleDescription.Clear();
                    txtModuleID.Clear();
                    txtModuleName.Clear();
                    frm.Show();
                    Close();
                }
                else MessageBox.Show("Insert Failed");
               
                
            }
            
        }

        private void txtLink_TextChanged(object sender, EventArgs e)
        {
            if (txtLink.Text.Contains("https://") || txtLink.Text.Contains("www."))
            {
                if (txtLink.Text.Contains(".com"))
                {
                    redCross.Visible = false;
                    greenTick.Visible = true;
                }
                else
                {
                    redCross.Visible = true;
                    greenTick.Visible = false;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtModuleID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModuleID.Text))
            {
                e.Cancel = true;
                txtModuleID.Focus();
                EPModuleID.SetError(txtModuleID, "This can not be empty");
            }
            else
            {
                e.Cancel = false;
                EPModuleID.SetError(txtModuleID, "");
            }
        }

        private void txtModuleName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModuleName.Text))
            {
                e.Cancel = true;
                txtModuleName.Focus();
                EPModuleName.SetError(txtModuleName, "This can not be empty");
            }
            else
            {
                e.Cancel = false;
                EPModuleName.SetError(txtModuleName, "");
            }
        }

        private void txtModuleDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModuleDescription.Text))
            {
                e.Cancel = true;
                txtModuleDescription.Focus();
                EPModuleDecription.SetError(txtModuleDescription, "This can not be empty");
            }
            else
            {
                e.Cancel = false;
                EPModuleDecription.SetError(txtModuleDescription, "");
            }
        }
    }
}