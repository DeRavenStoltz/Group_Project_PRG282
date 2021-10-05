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
    public partial class frmCreateStudents : Form
    {
        public frmCreateStudents()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            addAddressBox.Clear();
            addDateBirthBox.Clear();
            addFullNameBox.Clear();
            addModuleCodeBox.Clear();
            addModuleDesBox.Clear();
            addModuleNameBox.Clear();
            addPhoneBox.Clear();
            addStudNumBox.Clear();
        }

        private void btnBackSystem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
