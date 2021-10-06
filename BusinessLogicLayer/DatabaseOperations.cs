using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Group_Project_PRG282.BusinessLogicLayer
{
    class DatabaseOperations
    {
        public bool InsertStudents(SqlConnection connection, string fullName, string dateOfBirth, string studentGender, string studentPhone, string studentAddress)
        {
            string query = @"INSERT INTO tblStudents(studentFullName, studentDOB, studentGender, studentPhone, studentAddress) VALUES(@fullName, @dateOfBirth, @studentGender, @studentPhone, @studentAddress)";

            SqlParameter fullname = new SqlParameter("@fullName", SqlDbType.VarChar);
            SqlParameter dateofbirth = new SqlParameter("@dateOfBirth", SqlDbType.VarChar);
            SqlParameter gender = new SqlParameter("@studentGender", SqlDbType.VarChar);
            SqlParameter phone = new SqlParameter("@studentPhone", SqlDbType.VarChar);
            SqlParameter address = new SqlParameter("@studentAddress", SqlDbType.VarChar);

            fullname.Value = fullName.ToString();
            dateofbirth.Value = dateOfBirth.ToString();
            gender.Value = studentGender.ToString();
            phone.Value = studentPhone.ToString();
            address.Value = studentAddress.ToString();

            connection.Open();

            SqlCommand insertCommand = new SqlCommand(query, connection);

            insertCommand.Parameters.Add(fullname);
            insertCommand.Parameters.Add(dateofbirth);
            insertCommand.Parameters.Add(gender);
            insertCommand.Parameters.Add(phone);
            insertCommand.Parameters.Add(address);

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
                SqlCommand com = new SqlCommand(delString,connection);
                com.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
