using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Group_Project_PRG282.DataAccesLayer
{
    class DataHandler
    {
        public DataHandler() { }

        public SqlConnection ConnectDatabase()
        {
            SqlConnection connection = new SqlConnection("Server=(local); Initial Catalog=StudentSystem; Integrated Security=true");

            return connection;
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
                    byte[] byteData = (byte[])reader[6];
                    students.Add(new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), byteData));
                }
            }

            return students;
        }

    }
}
