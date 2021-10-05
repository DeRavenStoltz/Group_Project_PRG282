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

namespace Group_Project_PRG282.Presentation_Layer
{
    
    public partial class frmMain : Form
    {
        SqlConnection connection = new SqlConnection("Server=(local); Initial Catalog=NORTHWND; Integrated Security=true");
        public frmMain()
        {
            InitializeComponent(); 
        }
        public frmMain(string currentUser)
        {
            InitializeComponent();
            connection.Open();
            lblWelcome.Text = $"Welcome {currentUser}";

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=(local); Initial Catalog=StudentSystem; Integrated Security=true");

            connection.Open();

            SqlCommand getStudents = new SqlCommand("SELECT * FROM tblStudents", connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(getStudents);

            DataSet studentDataSet = new DataSet();

            dataAdapter.Fill(studentDataSet);

            studentDataGrid.DataSource = studentDataSet.Tables[0];

            connection.Close();
        }

    }
}
