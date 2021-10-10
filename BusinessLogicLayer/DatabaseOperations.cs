using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;

namespace Group_Project_PRG282.BusinessLogicLayer
{
    class DatabaseOperations
    {

       // public bool InsertStudents(SqlConnection connection, string fullName, string dateOfBirth, string studentGender, string studentPhone, string studentAddress)

        public byte[] UploadPhoto()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                byte[] bytes = null;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imageFileName = openFileDialog.FileName;
                    bytes = File.ReadAllBytes(imageFileName); 
                    return bytes;
                }
                return bytes;
            }
            
            
        }

        public bool InsertStudents(SqlConnection connection, string fullName, string dateOfBirth, string studentGender, string studentPhone, string studentAddress, byte[] imageBytes)

        {
            string query = @"INSERT INTO tblStudents(studentFullName, studentDOB, studentGender, studentPhone, studentAddress, studentImage) VALUES(@fullName, @dateOfBirth, @studentGender, @studentPhone, @studentAddress, @studentImage)";

            SqlParameter fullname = new SqlParameter("@fullName", SqlDbType.VarChar);
            SqlParameter dateofbirth = new SqlParameter("@dateOfBirth", SqlDbType.VarChar);
            SqlParameter gender = new SqlParameter("@studentGender", SqlDbType.VarChar);
            SqlParameter phone = new SqlParameter("@studentPhone", SqlDbType.VarChar);
            SqlParameter address = new SqlParameter("@studentAddress", SqlDbType.VarChar);
            SqlParameter photo = new SqlParameter("@studentImage", SqlDbType.Binary);

            fullname.Value = fullName.ToString();
            dateofbirth.Value = dateOfBirth.ToString();
            gender.Value = studentGender.ToString();
            phone.Value = studentPhone.ToString();
            address.Value = studentAddress.ToString();
            photo.Value = imageBytes;

            connection.Open();

            SqlCommand insertCommand = new SqlCommand(query, connection);

            insertCommand.Parameters.Add(fullname);
            insertCommand.Parameters.Add(dateofbirth);
            insertCommand.Parameters.Add(gender);
            insertCommand.Parameters.Add(phone);
            insertCommand.Parameters.Add(address);
            insertCommand.Parameters.Add(photo);

            insertCommand.ExecuteNonQuery();

            connection.Close();
            return true;
        }
        public List<Student> SearchStudent(List<Student> students, string search)
        {
            List<Student> searchedStudents = new List<Student>();
            if (search=="")
            {
                searchedStudents = students;
            }
            else
            {
                foreach (Student stud in students)
                {
                    //if (stud.FullName.Contains(search))
                    //{
                    //    searchedStudents.Add(stud);
                    //}
                    try
                    {
                        if (stud.StudentNumber == int.Parse(search))
                        {
                            searchedStudents.Add(stud);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please enter valid student number");
                        return students;
                        
                    }

                }
            }
           
            return searchedStudents;
        }
        public void deleteStudent(SqlConnection connection, int ID, string fullName)
        {
            connection.Open();
            DialogResult userInput;
            userInput = MessageBox.Show($"Are you sure you want to delete student, {fullName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string delString = $"DELETE FROM tblStudents WHERE studentNumber = {ID} ";

            if (userInput == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand(delString,connection);
                com.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
