using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Project_Hydac_Final
{
    internal class DataHandler
    {
        private string _dataFileName;

        public string DataFileName
        {
            get { return _dataFileName; }
        }

        public DataHandler(string dataFileName)
        {
            _dataFileName = dataFileName;
        }



        public Visit[] LoadVisits()
        {
            if (!File.Exists(DataFileName))     //Hvis filen visits.txt ikke findes endnu,
            {
                return new Visit[0];                //returneres et tomt array af besøg.
            }

            StreamReader sr = new StreamReader(DataFileName);

            int numberOfVisits = 0;

            string line = sr.ReadLine();

            while (line != null)
            {
                numberOfVisits++;
                line = sr.ReadLine();
            }

            sr.Close();


            Visit[] visits = new Visit[numberOfVisits];

            sr = new StreamReader(DataFileName);

            line = sr.ReadLine();

            int visitIndex = 0;

            while (line != null)
            {
                string[] visitInfo = line.Split(';');

                int visitNumber = int.Parse(visitInfo[0]);
                string guestName = visitInfo[1];
                string company = visitInfo[2];
                string responsiblePersonName = visitInfo[3];
                string roomName = visitInfo[4];
                DateTime arrival = DateTime.Parse(visitInfo[5]);


                Guest guest = new Guest(guestName, company);

                ResponsiblePerson responsiblePerson = new ResponsiblePerson(responsiblePersonName);

                Room room = new Room(roomName);


                Visit visit = new Visit(visitNumber, guest, responsiblePerson, room);

                visit.Arrival = arrival;

                visits[visitIndex] = visit;

                visitIndex++;

                line = sr.ReadLine();
            }

            sr.Close();

            return visits;
        }

        public void SaveVisits(Visit[] visits)
        {
            StreamWriter sw = new StreamWriter(DataFileName);

            foreach (Visit visit in visits)
            {
                sw.WriteLine(visit.VisitNumber + ";" +
                            visit.Guest.Name + ";" +
                            visit.Guest.Company + ";" +
                            visit.ResponsiblePerson.Name + ";" +
                            visit.Room.Name + ";" +
                            visit.Arrival);
            }

            sw.Close();
        }
    }
}
