using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Group_Project_PRG282.Presentation_Layer
{
    public partial class frmAddStudents : Form
    {

        DataHandler dh = new DataHandler();
        DatabaseOperations operations = new DatabaseOperations();
        ComponentController cc = new ComponentController();
        List<Module> lmod = new List<Module>();
        byte[] bytes;

        public frmAddStudents()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lmod = dh.GetModules(dh.ConnectDatabase());
            cc.fillCBXModule(cbxModule);
            lbxModules.Items.Clear();
            addFullName.Clear();
            addStudPhone.Clear();
            addStudAddress.Clear();
            addFullName.Focus();
        }

        private void frmAddStudents_Load(object sender, EventArgs e)
        {
            lmod = dh.GetModules(dh.ConnectDatabase());
            addFullName.Focus();
            cc.fillCBXModule(cbxModule);
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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            List<Module> AddedModules = new List<Module>();
            foreach (Module mod in lmod)
            {
                if (lbxModules.Items.Contains(mod.ModuleID))
                {
                    AddedModules.Add(mod);
                }
            }
            string gender;
            if (rdioAddMale.Checked)
            {
                gender = rdioAddMale.Text;
            }
            else
            {
                gender = rdioAddFemale.Text;
            }

           

            if (operations.InsertStudents(dh.ConnectDatabase(), addFullName.Text, addDatePicker.Text, gender, addStudPhone.Text, addStudAddress.Text, bytes,AddedModules) == true)
            {
                MessageBox.Show("Student Added Succesfully");
            }
            else
            {
                MessageBox.Show("There was an error, please try again");
            }
            
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