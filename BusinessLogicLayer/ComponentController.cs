
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_Project_PRG282.DataAccesLayer;




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
        
        public void fillUpdateCBX(ComboBox cbx,ListBox lbx, List<Module> lmod)
        {
            foreach (Module mod in lmod)
            {
                if (!lbx.Items.Contains(mod.ModuleID))
                {
                    cbx.Items.Add(mod.ModuleID);
                }
            }
        }

        public void AddModuleLBX(ListBox lbxModules, ComboBox cbxModule)
        {
            if (cbxModule.Text == "")
            {
                MessageBox.Show("Please select a module to add");
            }
            else
            {
                lbxModules.Items.Add(cbxModule.SelectedItem);
                cbxModule.Items.Remove(cbxModule.SelectedItem);
                cbxModule.Text = "";
            }
        }

        public void RemoveModuleLBX(ListBox lbxModules, ComboBox cbxModule)
        {
            if (lbxModules.SelectedIndex == -1)
            {
                MessageBox.Show("Select Item to remove");
            }
            else
            {
                cbxModule.Items.Add(lbxModules.SelectedItem);
                lbxModules.Items.Remove(lbxModules.SelectedItem);
            }
        }
    }
}