using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Group_Project_PRG282.BusinessLogicLayer
{
    internal class DatabaseOperations
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
            foreach (Student stud in students)
            {
                if (stud.FullName.Contains(search))
                {
                    searchedStudents.Add(stud);
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
                SqlCommand com = new SqlCommand(delString, connection);
                com.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void UpdateStudentInfo(SqlConnection connection, string id, string fullName, string dateOfBirth, string studentGender, string studentPhone, string studentAddress, byte[] imageBytes)
        {
            string query = "UPDATE tblStudents set studentFullName = @fullName, studentDOB= @dateOfBirth, studentGender = @studentGender,studentPhone= @studentPhone ,studentAddress= @studentAddress,studentImage = @studentImage WHERE studentNumber = @id";

            SqlParameter studentID = new SqlParameter("@id", SqlDbType.Int);
            SqlParameter fullname = new SqlParameter("@fullName", SqlDbType.VarChar);
            SqlParameter dateofbirth = new SqlParameter("@dateOfBirth", SqlDbType.VarChar);
            SqlParameter gender = new SqlParameter("@studentGender", SqlDbType.VarChar);
            SqlParameter phone = new SqlParameter("@studentPhone", SqlDbType.VarChar);
            SqlParameter address = new SqlParameter("@studentAddress", SqlDbType.VarChar);
            SqlParameter photo = new SqlParameter("@studentImage", SqlDbType.Binary);
            studentID.Value = int.Parse(id);
            fullname.Value = fullName.ToString();
            dateofbirth.Value = dateOfBirth.ToString();
            gender.Value = studentGender.ToString();
            phone.Value = studentPhone.ToString();
            address.Value = studentAddress.ToString();
            photo.Value = imageBytes;

            connection.Open();
            SqlCommand updateCommand = new SqlCommand(query, connection);

            updateCommand.Parameters.Add(studentID);
            updateCommand.Parameters.Add(fullname);
            updateCommand.Parameters.Add(dateofbirth);
            updateCommand.Parameters.Add(gender);
            updateCommand.Parameters.Add(phone);
            updateCommand.Parameters.Add(address);
            updateCommand.Parameters.Add(photo);

            updateCommand.ExecuteNonQuery();

            connection.Close();
        }
    }
}

//string newquery = $"UPDATE tblStudents SET studentFullName = '{fullName}',studentDOB = '{dateOfBirth}', studentGender = '{studentGender}', studentPhone = '{studentPhone}', studentAddress =  '{studentAddress}',studentImage= '"{}"' WHERE studentNumber =  {id} ";

//SqlParameter photo = new SqlParameter("@studentImage", SqlDbType.Binary);
//photo.Value = imageBytes;
//connection.Open();
//SqlCommand insertCommand = new SqlCommand(newquery, connection);
//insertCommand.Parameters.Add(photo);
//insertCommand.ExecuteNonQuery();
//connection.Close();
//==============================================================================================
//string binary = Convert.ToString(imageBytes[20]);
//string newquery = $"UPDATE tblStudents SET studentFullName = '{fullName}',studentDOB = '{dateOfBirth}', studentGender = '{studentGender}', studentPhone = '{studentPhone}', studentAddress =  '{studentAddress}',studentImage = {binary}  WHERE studentNumber =  {id} ";
////SqlParameter photo = new SqlParameter("@studentImage", SqlDbType.Binary);
////photo.Value = imageBytes;
//connection.Open();
//SqlCommand insertCommand = new SqlCommand(newquery, connection);
////insertCommand.Parameters.Add(photo);
//insertCommand.ExecuteNonQuery();
//connection.Close();
// ==============================
//MemoryStream memoryStream = new MemoryStream(imageBytes);
//Image image = Image.FromStream(memoryStream);
//==============================
//string query = "UPDATE tblStudents set studentFullName='" + fullName + "', studentDOB='" + dateOfBirth + "', studentGender='" + studentGender + "',studentPhone='" + studentPhone + "',studentAddress='" + studentAddress + "',@studentImage WHERE studentNumber ='" + id + "'";
//string query = "UPDATE tblStudents set studentFullName = @fullName, studentDOB= @dateOfBirth, studentGender = @studentGender,studentPhone= @studentPhone ,studentAddress= @studentAddress ,studentImage = @studentImage WHERE studentNumber = @id";
//SqlParameter StudentID = new SqlParameter("@fullName", SqlDbType.Int);
//SqlParameter fullname = new SqlParameter("@fullName", SqlDbType.VarChar);
//SqlParameter dateofbirth = new SqlParameter("@dateOfBirth", SqlDbType.VarChar);
//SqlParameter gender = new SqlParameter("@studentGender", SqlDbType.VarChar);
//SqlParameter phone = new SqlParameter("@studentPhone", SqlDbType.VarChar);
//SqlParameter address = new SqlParameter("@studentAddress", SqlDbType.VarChar);
//SqlParameter photo = new SqlParameter("@studentImage", SqlDbType.Binary);

//StudentID.Value =int.Parse(StudentID);
//fullname.Value = fullName.ToString();
//dateofbirth.Value = dateOfBirth.ToString();
//gender.Value = studentGender.ToString();
//phone.Value = studentPhone.ToString();
//address.Value = studentAddress.ToString();
//photo.Value = imageBytes;

//connection.Open();

//SqlCommand insertCommand = new SqlCommand(query, connection);

//insertCommand.Parameters.Add(StudentID);
//insertCommand.Parameters.Add(fullname);
//insertCommand.Parameters.Add(dateofbirth);
//insertCommand.Parameters.Add(gender);
//insertCommand.Parameters.Add(phone);
//insertCommand.Parameters.Add(address);
//insertCommand.Parameters.Add(photo);

//insertCommand.ExecuteNonQuery();

//connection.Close();
//=======================================================
//string query = "UPDATE tblStudents set studentFullName='" + fullName + "', studentDOB='" + dateOfBirth + "', studentGender='" + studentGender + "',studentPhone='" + studentPhone + "',studentAddress='" + studentAddress + "',@studentImage WHERE studentNumber ='" + id + "'";
//SqlParameter StudentID = new SqlParameter("@fullName", SqlDbType.Int);
//SqlParameter fullname = new SqlParameter("@fullName", SqlDbType.VarChar);
//SqlParameter dateofbirth = new SqlParameter("@dateOfBirth", SqlDbType.VarChar);
//SqlParameter gender = new SqlParameter("@studentGender", SqlDbType.VarChar);
//SqlParameter phone = new SqlParameter("@studentPhone", SqlDbType.VarChar);
//SqlParameter address = new SqlParameter("@studentAddress", SqlDbType.VarChar);
//SqlParameter photo = new SqlParameter("@studentImage", SqlDbType.Binary);

//StudentID.Value =int.Parse(StudentID);
//fullname.Value = fullName.ToString();
//dateofbirth.Value = dateOfBirth.ToString();
//gender.Value = studentGender.ToString();
//phone.Value = studentPhone.ToString();
//address.Value = studentAddress.ToString();
//photo.Value = imageBytes;

//connection.Open();

//SqlCommand insertCommand = new SqlCommand(query, connection);

//insertCommand.Parameters.Add(StudentID);
//insertCommand.Parameters.Add(fullname);
//insertCommand.Parameters.Add(dateofbirth);
//insertCommand.Parameters.Add(gender);
//insertCommand.Parameters.Add(phone);
//insertCommand.Parameters.Add(address);
//insertCommand.Parameters.Add(photo);

//insertCommand.ExecuteNonQuery();

//connection.Close();