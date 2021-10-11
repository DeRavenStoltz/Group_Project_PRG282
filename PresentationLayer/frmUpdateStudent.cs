using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer;
using Group_Project_PRG282.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Group_Project_PRG282.PresentationLayer
{
    public partial class frmUpdateStudent : Form
    {
        private List<Student> students = new List<Student>();
        private DatabaseOperations operations = new DatabaseOperations();
        private DataHandler datahandler = new DataHandler();

        //byte[] data;
        private byte[] bytes;

        public frmUpdateStudent()
        {
            InitializeComponent();
        }

        public frmUpdateStudent(byte[] photo, int id, string name, string dob, string gender, string phone, string address)
        {
            InitializeComponent();
            MemoryStream memoryStream = new MemoryStream(photo);
            Image image = Image.FromStream(memoryStream);
            bytes = photo;
            picStudentUpload.Image = image;
            txtFullName.Text = name;
            dtpDatePicker.Text = dob;
            if (gender == "Male")
            {
                rdbMale.Checked = true;
            }
            if (gender == "Female")
            {
                rdbFemale.Checked = true;
            }
            txtPhone.Text = phone;
            txtAddress.Text = address;
            TxtStudentID.Text = id.ToString();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            students = datahandler.GetStudents(datahandler.ConnectDatabase());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //FullName.Text = Update.
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentGender = "";
            if (rdbMale.Checked)
            {
                studentGender = "Male";
            }
            if (rdbFemale.Checked)
            {
                studentGender = "Female";
            }

            try
            {
                operations.UpdateStudentInfo(datahandler.ConnectDatabase(), TxtStudentID.Text, txtFullName.Text, dtpDatePicker.Text, studentGender, txtPhone.Text, txtAddress.Text, bytes);
                MessageBox.Show("Information successfully updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Please try again", ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            addStudCode.Clear();
            addStudModuleName.Clear();
            addStudModuleDes.Clear();
            txtFullName.Focus();
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            //DatabaseOperations operations = new DatabaseOperations();
            //data = operations.UploadPhoto();
            //MemoryStream memoryStream = new MemoryStream(data);
            //Image image = Image.FromStream(memoryStream);
            //picStudentUpload.Image = image;

            DatabaseOperations operations = new DatabaseOperations();
            bytes = operations.UploadPhoto();
            MemoryStream memoryStream = new MemoryStream(bytes);
            Image image = Image.FromStream(memoryStream);
            picStudentUpload.Image = image;
        }
    }
}