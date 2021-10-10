﻿using Group_Project_PRG282.BusinessLogicLayer;
using Group_Project_PRG282.DataAccesLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Group_Project_PRG282.Presentation_Layer
{
    public partial class frmAddStudents : Form
    {
        private byte[] bytes;

        public frmAddStudents()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            addFullName.Clear();
            addStudPhone.Clear();
            addStudAddress.Clear();
            addStudCode.Clear();
            addStudModuleName.Clear();
            addStudModuleDes.Clear();
            addFullName.Focus();
        }

        private void frmAddStudents_Load(object sender, EventArgs e)
        {
            addFullName.Focus();
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
            string gender;
            if (rdioAddMale.Checked)
            {
                gender = rdioAddMale.Text;
            }
            else
            {
                gender = rdioAddFemale.Text;
            }

            DataHandler dh = new DataHandler();
            DatabaseOperations operations = new DatabaseOperations();

            if (operations.InsertStudents(dh.ConnectDatabase(), addFullName.Text, addDatePicker.Text, gender, addStudPhone.Text, addStudAddress.Text, bytes) == true)
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
    }
}