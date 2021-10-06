using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_PRG282.Presentation_Layer
{
    class ComponentController//For clearing or adjusting all visual components
    {
        

        public void clearFieldsLogIn(TextBox txtName,TextBox txtPass)
        {
            txtName.Clear();
            txtPass.Clear();
        }
    }
}
