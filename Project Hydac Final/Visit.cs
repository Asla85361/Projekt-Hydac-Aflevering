using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Hydac_Final
{
    internal class Visit
    {
        public int VisitNumber { get; set; }

        public Guest Guest { get; set; }

        public ResponsiblePerson ResponsiblePerson { get; set; }

        public Room Room { get; set; }

        public DateTime Arrival { get; set; }

        public Visit(int visitNumber, Guest guest,
                     ResponsiblePerson responsiblePerson,
                     Room room)
        {
            VisitNumber = visitNumber;
            Guest = guest;
            ResponsiblePerson = responsiblePerson;
            Room = room;
            Arrival = DateTime.Now;
        }
    }
}
