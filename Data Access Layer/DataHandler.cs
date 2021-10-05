using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Threading;


using Group_Project_PRG282.Presentation_Layer;

namespace Group_Project_PRG282
{
    class DataHandler
    {

        public SqlConnection ConnectDatabase()
        {
            SqlConnection connection = new SqlConnection("Server=(local); Initial Catalog=StudentSystem; Integrated Security=true");

            return connection;
        }

        public bool UserLogin(SqlConnection connection, string user, string pass)
        {
            try
            {
                SqlCommand userLoginCommand = new SqlCommand("SELECT userName, userPassword FROM tblSystemUsers WHERE userName = @Username AND userPassword = @Password", connection);

                SqlParameter username = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter password = new SqlParameter("@Password", SqlDbType.VarChar);

                username.Value = user;
                password.Value = pass;

                userLoginCommand.Parameters.Add(username);
                userLoginCommand.Parameters.Add(password);

                //userLoginCommand.Connection.Open();

                connection.Open();

                SqlDataReader reader = userLoginCommand.ExecuteReader(CommandBehavior.CloseConnection);


                if (reader.Read() == true)
                {
                    return true;

                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            return false;
        }

        public List<Student> GetStudents(SqlConnection connection)
        {
            List<Student> students = new List<Student>();

            connection.Open();

            SqlCommand studentCommand = new SqlCommand(@"SELECT * FROM tblStudents", connection);

            SqlDataReader reader = studentCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    students.Add(new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                }
            }

            return students;
        }

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
    }
}
