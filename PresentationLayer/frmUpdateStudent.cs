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
        ComponentController cc = new ComponentController();
        List<Module> lmod = new List<Module>();//All modules
        List<string> lcurrentModules = new List<string>();//Modules for selected student
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
            lcurrentModules = operations.studentModules(id,datahandler.ConnectDatabase());
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            foreach (var item in lcurrentModules)
            {
                lbxModules.Items.Add(item);
            }          
            students = datahandler.GetStudents(datahandler.ConnectDatabase());
            txtFullName.Focus();
            lmod = datahandler.GetModules(datahandler.ConnectDatabase());
            cc.fillUpdateCBX(cbxModule, lbxModules, lmod);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //FullName.Text = Update.
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            List<string> ladd = new List<string>();//added modules
            List<string> ldel = new List<string>();//removed modules
            foreach (string code in lbxModules.Items)
            {
                if (!lcurrentModules.Contains(code))
                {
                    ladd.Add(code);
                }
            }

            foreach (string code in lcurrentModules)
            {
                if (!lbxModules.Items.Contains(code))
                {
                    ldel.Add(code);
                }
            }    
                
            
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
                operations.UpdateStudentModules(ldel,ladd,int.Parse(TxtStudentID.Text),datahandler.ConnectDatabase());
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
            lmod = datahandler.GetModules(datahandler.ConnectDatabase());
            lbxModules.Items.Clear();
            cc.fillCBXModule(cbxModule);
            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtFullName.Focus();
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            DatabaseOperations operations = new DatabaseOperations();
            bytes = operations.UploadPhoto();
            MemoryStream memoryStream = new MemoryStream(bytes);
            Image image = Image.FromStream(memoryStream);
            picStudentUpload.Image = image;
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            cc.AddModuleLBX(lbxModules, cbxModule);
        }

        private void btnRemoveModule_Click(object sender, EventArgs e)
        {
            cc.RemoveModuleLBX(lbxModules, cbxModule);
        }
    }
}