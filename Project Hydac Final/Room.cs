using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Hydac_Final
{
    internal class Room
    {
        public string Name { get; set; }

        public Room(string name)
        {
            Name = name;
        }

        public void Reserve()
        {
            Console.WriteLine("Room " + Name + " is reserved.");
        }

        public void Release()
        {
            Console.WriteLine("Room " + Name + " is released.");
        }
    }
}
