using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer;
using Group_Project_PRG282.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Group_Project_PRG282.Presentation_Layer
{
    public partial class frmMain : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private List<Student> students = new List<Student>();
        private DatabaseOperations operations = new DatabaseOperations();
        private DataHandler datahandler = new DataHandler();
        private List<string> studentModules = new List<string>();

        public frmMain()
        {
            InitializeComponent();
            lblWelcome.Text = $"{User.LoggedInUser[0].Username}";
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

                populateModules(selectedStudent.StudentNumber);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)bindingSource.Current;
            frmUpdateStudent newForm = new frmUpdateStudent(selectedStudent.Photo, selectedStudent.StudentNumber, selectedStudent.FullName, selectedStudent.DateOfBirth, selectedStudent.StudentGender, selectedStudent.StudentPhone, selectedStudent.StudentAddress);
            newForm.Show();
            Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)bindingSource.Current;
            frmUpdateStudent newForm = new frmUpdateStudent(selectedStudent.Photo, selectedStudent.StudentNumber, selectedStudent.FullName, selectedStudent.DateOfBirth, selectedStudent.StudentGender, selectedStudent.StudentPhone, selectedStudent.StudentAddress);
            newForm.Show();
            Close();
        }

        public void populateModules(int ID)
        {
            studentModules = datahandler.getStudentModule(datahandler.ConnectDatabase(), ID);
            lbModules.Items.Clear();
            foreach (var module in studentModules)
            {
                lbModules.Items.Add(module);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmNavigation frmNav = new frmNavigation();
            frmNav.Show();
            Close();
        }
    }
}