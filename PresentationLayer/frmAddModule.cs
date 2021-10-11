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

namespace Group_Project_PRG282.PresentationLayer
{
    public delegate void operationSuccess(); 

    public partial class frmAddModule : Form
    {
        public event operationSuccess moduleAdded; 

        DataHandler dh = new DataHandler();
        DatabaseOperations op = new DatabaseOperations();
        frmModules frm;
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
            if (op.InsertModules(dh.ConnectDatabase(), txtModuleID.Text, txtModuleName.Text, txtModuleDescription.Text,txtLink.Text))
            {
                MessageBox.Show("Insert Completed");
                if (moduleAdded != null)
                {
                    moduleAdded();
                }
            }
            else MessageBox.Show("Insert Failed");
            txtModuleDescription.Clear();
            txtModuleID.Clear();
            txtModuleName.Clear();
            frm.Show();
            Close();
        }

        private void frmAddModule_Load(object sender, EventArgs e)
        {

        }
    }
}
