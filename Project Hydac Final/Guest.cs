using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Project_Hydac_Final
{
    internal class Guest
    {
        public string Name { get; set; }
        public string Company { get; set; }

        public Guest(string name, string company)
        {
            Name = name;
            Company = company;
        }
    }
}

