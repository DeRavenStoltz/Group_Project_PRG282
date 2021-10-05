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
        SqlConnection connection = new SqlConnection("Server=(local); Initial Catalog=StudentSystem; Integrated Security=true");

        public bool UserLogin(string user, string pass)
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

        public List<Student> GetStudents()
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
    }
}
