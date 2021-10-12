using Group_Project_PRG282.Presentation_Layer;
using System;
using System.Windows.Forms;

namespace Group_Project_PRG282.PresentationLayer
{
    public partial class frmNavigation : Form
    {
        public frmNavigation()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            Close();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            frmModules modules = new frmModules();
            modules.Show();
            Close();
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