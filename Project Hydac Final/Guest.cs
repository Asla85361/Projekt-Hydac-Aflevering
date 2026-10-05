using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Hydac_Final
{
    public class Guest
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

