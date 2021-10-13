using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG282.BusinessLogicLayer
{
    class Validation
    {
        public bool ModuleCheckNull(string name, string descr)
        {
            if (name == "" || descr == "")
            {
                MessageBox.Show("Ensure all fields are entered");
                return false;
            }
            else return true;
        }
        public bool ModuleCode(string id)
        {
            if (id.Length!= 3 && id.Length != 2)
            {
                MessageBox.Show("Ensure Module Code contains 2 or 3 Characters");
                return false;
            }

            foreach (var item in id)
            {
                if (!Char.IsLetter(item))
                {
                    MessageBox.Show("Only Letters in module Code");
                    return false;
                }
            }
            return true;
        }
        public bool FinalValidate(string id, string name, string descr)
        {
            if (ModuleCheckNull(name, descr) )
            {
                if (ModuleCode(id))
                {
                    return true;
                }
                else return false;
                
            }
            else return false;
        }

        public bool RegisterValidation(string password,string username)
        {
            if (password==""||username=="")
            {
                MessageBox.Show("Fill in all fields");
                return false;
            }

            if (password.Length >= 8)
            {
                bool up = false;
                foreach (var let in password)
                {
                    if (Char.IsUpper(let))
                    {
                        up = true;
                    }
                }
                if (!up)
                {
                    MessageBox.Show("Password must contain at least 1 uppercase letter");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Password must contain at least 8 characters");
                return false;
            }



            return true;
        }
    }
}
