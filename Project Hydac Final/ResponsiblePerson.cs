using System;
using System.Collections.Generic;
using System.Text;

namespace MyHydac
{
    internal class ResponsiblePerson
    {
        public string Name { get; set; }

        public ResponsiblePerson(string name)
        {
            Name = name;
        }

        public void SendNotification()
        {
            Console.WriteLine("Notification sent to " + Name);
        }
    }
}
