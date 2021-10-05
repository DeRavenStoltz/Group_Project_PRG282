using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG282.Presentation_Layer
{
    public partial class frmAddStudents : Form
    {
        public frmAddStudents()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            addStudNumber.Clear();
            addFullName.Clear();
            addStudPhone.Clear();
            addStudAddress.Clear();
            addStudCode.Clear();
            addStudModuleName.Clear();
            addStudModuleDes.Clear();
            addStudNumber.Focus();
        }

        private void frmAddStudents_Load(object sender, EventArgs e)
        {
            addStudNumber.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
