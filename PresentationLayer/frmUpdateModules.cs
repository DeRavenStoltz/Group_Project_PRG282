using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Project_PRG282.PresentationLayer;
using Group_Project_PRG282.DataAccesLayer;
using Group_Project_PRG282.BusinessLogicLayer; 

namespace Group_Project_PRG282.BusinessLogicLayer
{
    public delegate void opperationSuccess(); 

    public partial class frmUpdateModules : Form
    {
        public event opperationSuccess updateSuccess;
        frmModules frmModules = new frmModules();
        DatabaseOperations dbo = new DatabaseOperations();
        DataHandler dh = new DataHandler();
        frmModules frm;


        public frmUpdateModules()
        {
            InitializeComponent();
        }
        public frmUpdateModules(frmModules frmmod, string ID, string Name, string Description, string link)
        {
            InitializeComponent();
            frm = frmmod;
            txtCode.Text = ID;
            txtModuleName.Text = Name;
            txtDescription.Text = Description;
            txtLink.Text = link;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtModuleName.Clear(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dbo.updateModule(dh.ConnectDatabase(), txtCode.Text, txtModuleName.Text, txtDescription.Text,txtLink.Text);
            if (updateSuccess != null)
            {
                updateSuccess(); 
            }
            frm.Show();
            Close(); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmModules.Show();
            Close(); 
        }

        private void frmUpdateModules_Load(object sender, EventArgs e)
        {

        }
    }
}
