using System.Windows.Forms;

namespace Group_Project_PRG282.Presentation_Layer
{
    internal class ComponentController//For clearing or adjusting all visual components
    {
        public void clearFieldsLogIn(TextBox txtName, TextBox txtPass)
        {
            txtName.Clear();
            txtPass.Clear();
        }
    }
}