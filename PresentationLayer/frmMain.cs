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

using Group_Project_PRG282.DataAccesLayer;
using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.Presentation_Layer;

namespace Group_Project_PRG282.Presentation_Layer
{
    
    public partial class frmMain : Form
    {
        BindingSource bindingSource = new BindingSource();
        List<Student> students = new List<Student>();
        DatabaseOperations operations = new DatabaseOperations();
        DataHandler datahandler = new DataHandler();
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string currentUser)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome, {currentUser}";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmAddStudents addStudents = new frmAddStudents();
            addStudents.Show();
            Close();
        }
        private void frmMain_Load_1(object sender, EventArgs e)
        {
            students = datahandler.GetStudents(datahandler.ConnectDatabase());
            bindingSource.DataSource = students;
            studentDataGrid.DataSource = bindingSource;
        }
        private void studentDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            studentDataGrid.Columns[6].Visible = false;
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


                MemoryStream memoryStream = new MemoryStream(selectedStudent.Photo);
                Image image = Image.FromStream(memoryStream);
                studentImageBox.Image = image;


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
            bindingSource.DataSource = operations.SearchStudent(students, searchBox.Text);
            studentDataGrid.DataSource = bindingSource;

        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = students;
            studentDataGrid.DataSource = bindingSource;
        }
        private void linkSwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult userResult = MessageBox.Show("Are you sure you want to switch users?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (userResult == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)bindingSource.Current;
            operations.deleteStudent(datahandler.ConnectDatabase(), selectedStudent.StudentNumber, selectedStudent.FullName);
            students.Clear();
            students = datahandler.GetStudents(datahandler.ConnectDatabase());
            bindingSource.DataSource = students;
        }
    }
}
