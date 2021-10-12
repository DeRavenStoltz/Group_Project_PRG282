﻿using System.Collections.Generic;
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

            SqlConnection connection = new SqlConnection(@"Server=.;Initial Catalog=StudentSystem; Initial Catalog=StudentSystem; Integrated Security=true");


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

        public List<string> getStudentModule(SqlConnection connection, int ID)
        {
            List<string> modules = new List<string>();

            connection.Open();

            SqlCommand cmd = new SqlCommand($@"SELECT M.moduleName FROM tblStudents AS S INNER JOIN StudentModule AS SM ON S.studentNumber = SM.studentNumber INNER JOIN tblModules AS M ON M.moduleCode = SM.moduleCode WHERE S.studentNumber = {ID}", connection);
            SqlDataReader reader = cmd.ExecuteReader(); 
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    modules.Add(reader.GetString(0));
                }
            }
            return modules; 
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
                    modules.Add(new Module(reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetString(3)));
                }
            }
            connection.Close();
            return modules;
        }


    }
}