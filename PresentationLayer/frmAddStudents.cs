using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Group_Project_PRG282.Presentation_Layer
{
    public partial class frmAddStudents : Form
    {
        private DataHandler dh = new DataHandler();
        private DatabaseOperations operations = new DatabaseOperations();
        private ComponentController cc = new ComponentController();
        private List<Module> lmod = new List<Module>();
        private byte[] bytes;

        public frmAddStudents()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lmod = dh.GetModules(dh.ConnectDatabase());
            cbxModule.Items.Clear();
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
            Application.Exit();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            bool DataCorrect = false;
            List<Module> AddedModules = new List<Module>();
            string gender;
            if (bytes != null)
            {
                if (dh.JustString(addFullName.Text))
                {
                    if ((this.rdioAddMale.Checked || this.rdioAddFemale.Checked))
                    {
                        if (dh.checkNumber(addStudPhone.Text))
                        {
                            if (addStudAddress.Text == "")
                            {
                                MessageBox.Show("Please fill in the student address");
                            }
                            else
                            {
                                if (lbxModules.Items.Count == 0)
                                {
                                    MessageBox.Show("Please choose a Module");
                                }
                                else
                                {
                                    DataCorrect = true;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please check if the phone number is correct");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose a gender");
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure both name and surname are entered and that they only contains letters. ");
                }
            }
            else
            {
                MessageBox.Show("Please select a photo");
            }
            if (rdioAddMale.Checked)
            {
                gender = rdioAddMale.Text;
            }
            else
            {
                gender = rdioAddFemale.Text;
            }
            foreach (Module mod in lmod)
            {
                if (lbxModules.Items.Contains(mod.ModuleID))
                {
                    AddedModules.Add(mod);
                }
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(addFullName.Text, "Message");
                MessageBox.Show(addStudAddress.Text, "Message");
                MessageBox.Show(addStudPhone.Text, "Message");
            }
            if (DataCorrect)
            {
                try
                {
                    operations.InsertStudents(dh.ConnectDatabase(), addFullName.Text, addDatePicker.Text, gender, addStudPhone.Text, addStudAddress.Text, bytes, AddedModules);
                    MessageBox.Show("Student Added Successfully");
                    frmMain main = new frmMain();
                    main.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error, please try again", ex.Message);
                }
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseOperations operations = new DatabaseOperations();
                bytes = operations.UploadPhoto();
                MemoryStream memoryStream = new MemoryStream(bytes);
                Image image = Image.FromStream(memoryStream);
                picStudentUpload.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please upload a photo", ex.Message);
            }
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            cc.AddModuleLBX(lbxModules, cbxModule);
        }

        private void btnRemoveModule_Click(object sender, EventArgs e)
        {
            cc.RemoveModuleLBX(lbxModules, cbxModule);
        }

        private void addFullName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addFullName.Text))
            {
                e.Cancel = true;
                addFullName.Focus();
                EPFullName.SetError(addFullName, "Name Should not be Blank");
            }
            else
            {
                e.Cancel = false;
                EPFullName.SetError(addFullName, "");
            }
        }

        private void addStudPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addStudPhone.Text))
            {
                e.Cancel = true;
                addFullName.Focus();
                EPStudnetPhone.SetError(addStudPhone, "Phone should not be Blank");
            }
            else
            {
                e.Cancel = false;
                EPStudnetPhone.SetError(addStudPhone, "");
            }
        }

        private void addStudAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addStudAddress.Text))
            {
                e.Cancel = true;
                addFullName.Focus();
                EPStudentAddress.SetError(addStudAddress, "Phone should not be Blank");
            }
            else
            {
                e.Cancel = false;
                EPStudentAddress.SetError(addStudAddress, "");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}