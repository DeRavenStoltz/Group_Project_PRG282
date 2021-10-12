using System;
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Images|*.jpg;*.png;*.jpeg", ValidateNames = true, Multiselect = false })
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

        public void InsertStudents(SqlConnection connection, string fullName, string dateOfBirth, string studentGender, string studentPhone, string studentAddress, byte[] imageBytes, List<Module> lAddedModules)

        {
            try
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

                //StudentModules

                query = @"Insert into StudentModule(moduleCode,studentNumber) Values(@modcode,@studnum)";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter modcode = new SqlParameter("@modcode", SqlDbType.VarChar);
                SqlParameter studnum = new SqlParameter("@studnum", SqlDbType.Int);

                foreach (Module mod in lAddedModules)
                {
                    cmd.Parameters.Clear();
                    modcode.Value = mod.ModuleID;
                    studnum.Value = NewestStudentID(connection);
                    cmd.Parameters.Add(modcode);
                    cmd.Parameters.Add(studnum);

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Something went wrong", ex.Message);
            }
        }

        public int NewestStudentID(SqlConnection connection)
        {
            int ID;
            string query = "Select Max(studentNumber) from tblStudents";
            SqlCommand cmd = new SqlCommand(query, connection);
            ID = (int)cmd.ExecuteScalar();
            return ID;
        }

        public List<string> studentModules(int studNumber, SqlConnection connection)//returns all modules for a specific student
        {
            List<string> lCodes = new List<string>();
            try
            {
                string query = $"Select moduleCode from StudentModule where studentNumber={studNumber}";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lCodes.Add(reader.GetString(0));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return lCodes;
        }

        public bool InsertModules(SqlConnection connection, string modID, string ModName, string ModDescr, string link)

        {
            try
            {
                string query = @"INSERT INTO tblModules VALUES(@ModuleID, @ModuleName, @ModuleDescription, @ModuleLink)";

                SqlParameter modid = new SqlParameter("@ModuleID", SqlDbType.VarChar);
                SqlParameter modname = new SqlParameter("@ModuleName", SqlDbType.VarChar);
                SqlParameter moddescr = new SqlParameter("@ModuleDescription", SqlDbType.VarChar);
                SqlParameter modlink = new SqlParameter("@ModuleLink", SqlDbType.VarChar);

                modid.Value = modID.ToString();
                modname.Value = ModName.ToString();
                moddescr.Value = ModDescr.ToString();
                modlink.Value = link;

                connection.Open();

                SqlCommand insertCommand = new SqlCommand(query, connection);

                insertCommand.Parameters.Add(modid);
                insertCommand.Parameters.Add(modname);
                insertCommand.Parameters.Add(moddescr);
                insertCommand.Parameters.Add(modlink);

                insertCommand.ExecuteNonQuery();

                connection.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public List<Student> SearchStudent(List<Student> students, string search)
        {
            List<Student> searchedStudents = new List<Student>();
            if (search == "")
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

        public List<Module> SearchModule(List<Module> modules, string search)
        {
            List<Module> searchedModule = new List<Module>();
            if (search == "")
            {
                searchedModule = modules;
            }
            else
            {
                foreach (Module mod in modules)
                {
                    try
                    {
                        if (mod.ModuleID == search)
                        {
                            searchedModule.Add(mod);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please enter valid ModuleCode");
                        return modules;
                    }
                }
            }

            return searchedModule;
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

        public void deleteModule(SqlConnection connection, string ID, string ModName)
        {
            connection.Open();
            DialogResult userInput;
            userInput = MessageBox.Show($"Are you sure you want to delete the module, {ModName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string delString = $"DELETE FROM tblModules WHERE ModuleCode = '{ID}' ";

            if (userInput == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand(delString, connection);
                com.ExecuteNonQuery();
                MessageBox.Show("Operation Completed");
            }
            connection.Close();
        }

        public void updateModule(SqlConnection connection, string ID, string ModName, string Description, string link)
        {
            connection.Open();
            string query = $@"UPDATE tblModules SET moduleName = '{ModName}', moduleDescription = '{Description}'  WHERE moduleCode = '{ID}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
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

        public void UpdateStudentModules(List<string> ldel, List<string> ladd, int ID, SqlConnection connection)
        {
            try
            {
                string query = @"Insert into StudentModule(moduleCode,studentNumber) Values(@modcode,@studnum)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter modcode = new SqlParameter("@modcode", SqlDbType.VarChar);
                SqlParameter studnum = new SqlParameter("@studnum", SqlDbType.Int);

                foreach (string mod in ladd)
                {
                    cmd.Parameters.Clear();
                    modcode.Value = mod;
                    studnum.Value = ID;
                    cmd.Parameters.Add(modcode);
                    cmd.Parameters.Add(studnum);

                    cmd.ExecuteNonQuery();
                }

                query = @"Delete from StudentModule where moduleCode = @modcode and studentNumber = @studnum";

                cmd = new SqlCommand(query, connection);
                modcode = new SqlParameter("@modcode", SqlDbType.VarChar);
                studnum = new SqlParameter("@studnum", SqlDbType.Int);

                foreach (string mod in ldel)
                {
                    cmd.Parameters.Clear();
                    modcode.Value = mod;
                    studnum.Value = ID;
                    cmd.Parameters.Add(modcode);
                    cmd.Parameters.Add(studnum);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

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