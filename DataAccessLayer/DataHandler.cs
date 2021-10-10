using System.Collections.Generic;
using System.Data.SqlClient;

namespace Group_Project_PRG282.DataAccesLayer
{
    internal class DataHandler
    {
        public DataHandler()
        {
        }

        public SqlConnection ConnectDatabase()
        {
            SqlConnection connection = new SqlConnection(@"Server=LAPTOP-S4VFC76G\SQLEXPRESS02; Initial Catalog=StudentSystem; Integrated Security=true");

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