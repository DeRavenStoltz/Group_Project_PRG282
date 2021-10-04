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
        SqlConnection connection;
        public frmMain()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=(local); Initial Catalog=NORTHWND; Integrated Security=true");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT FirstName + ' ' + LastName AS FullName FROM Employees WHERE EmployeeID = 1", connection);

            lblWelcome.Text = "Welcome, " + command.ExecuteScalar().ToString(); ;

            connection.Close();
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
