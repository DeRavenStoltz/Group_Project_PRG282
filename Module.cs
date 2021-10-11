using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project_PRG282
{
    class Module
    {
        string moduleID;
        string moduleName, moduleDescription,moduleLink;
        public Module()
        {
        }

        public Module(string moduleID, string moduleName, string moduleDescription,string moduleLink)
        {
            this.ModuleID = moduleID;
            this.ModuleName = moduleName;
            this.ModuleDescription = moduleDescription;
            ModuleLink = moduleLink;
        }

        public string ModuleID { get => moduleID; set => moduleID = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string ModuleDescription { get => moduleDescription; set => moduleDescription = value; }
        public string ModuleLink { get => moduleLink; set => moduleLink = value; }
    }
}
