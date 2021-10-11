
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Project_PRG282.DataAccesLayer;

﻿using System.Windows.Forms;


namespace Group_Project_PRG282.Presentation_Layer
{
    internal class ComponentController//For clearing or adjusting all visual components
    {

        DataHandler dh = new DataHandler();
        

        public void clearFieldsLogIn(TextBox txtName,TextBox txtPass)

        {
            txtName.Clear();
            txtPass.Clear();
        }
        public void fillCBXModule(ComboBox cbx)
        {
            List<Module> lmod = new List<Module>();
            lmod = dh.GetModules(dh.ConnectDatabase());
            foreach (Module module in lmod)
            {
                cbx.Items.Add(module.ModuleID);
            }
        }

        public void fillModuleList(ListView lv,List<Module> lmod)
        {
            Module newMod = lmod[lmod.Count - 1];
            for (int i = 0; i < lmod.Count-1; i++)
            {
                if (lmod[i].ModuleID == newMod.ModuleID)
                {
                    MessageBox.Show("Module already added");
                    break;
                }
            }
            
            lv.Items.Add($"Module ID: {newMod.ModuleID}\tModule Name: {newMod.ModuleName}");
        }
    }
}