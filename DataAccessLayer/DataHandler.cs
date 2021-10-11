using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Group_Project_PRG282.DataAccesLayer
{
    internal class DataHandler
    {
        public DataHandler()
        {
        }

        public SqlConnection ConnectDatabase()
        {

            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-IHTCUHK\SQLEXPRESS; Initial Catalog=StudentSystem; Integrated Security=true");


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

        public List<Module> GetModules(SqlConnection connection)
        {
            List<Module> modules = new List<Module>();
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return modules;
                
            }
            

            SqlCommand cmd = new SqlCommand(@"SELECT * FROM tblModules", connection);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {        
                    modules.Add(new Module(reader.GetString(0),reader.GetString(1),reader.GetString(2)));
                }
            }
            connection.Close();
            return modules;
        }


    }
}