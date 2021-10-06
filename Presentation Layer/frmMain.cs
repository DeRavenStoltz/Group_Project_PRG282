using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG282.Presentation_Layer
{
    
    public partial class frmMain : Form
    {
        SqlConnection connection;
        BindingSource bindingSource = new BindingSource();
        List<Student> students = new List<Student>();
        public frmMain()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=(local); Initial Catalog=StudentSystem; Integrated Security=true");
        }
        public frmMain(string currentUser)
        {
            DataHandler datahandler = new DataHandler();
            students = datahandler.GetStudents(datahandler.ConnectDatabase());
            bindingSource.DataSource = students;
            studentDataGrid.DataSource = bindingSource;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmAddStudents addStudents = new frmAddStudents();
            addStudents.Show();
            this.Hide();
        }

        private void studentDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)bindingSource.Current;
            if (selectedStudent != null)
            {
                lblFullName.Text = selectedStudent.FullName;
                lblStudNumber.Text = selectedStudent.StudentNumber.ToString();
                lblGender.Text = selectedStudent.StudentGender;
                lblPhoneNumber.Text = selectedStudent.StudentPhone;
                lblDateOfBirth.Text = selectedStudent.DateOfBirth;
                lblPhysicalAddress.Text = selectedStudent.StudentAddress;
                lblFullNameTop.Text = selectedStudent.FullName;

            }
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            bindingSource.MoveFirst();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        private void buttonMoveNext_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            bindingSource.MoveLast();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
            bindingSource.DataSource = dh.SearchStudent(students, searchBox.Text);
            studentDataGrid.DataSource = bindingSource;

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = students;
            studentDataGrid.DataSource = bindingSource;
        }
    }
}
