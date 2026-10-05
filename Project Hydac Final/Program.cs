using Project_Hydac_Final;

namespace Project_Hydac_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataHandler dataHandler = new DataHandler("visits.txt");

            bool running = true;

            Visit[] visits = dataHandler.LoadVisits();
            int nextVisitNumber = 1;
            foreach (Visit visit in visits)
            {
                if (visit.VisitNumber >= nextVisitNumber)
                {
                    nextVisitNumber = visit.VisitNumber + 1;
                }
            }

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("HYDAC");
                Console.WriteLine("1. Opret ankomst");
                Console.WriteLine("2. Afslut");
                Console.Write("Vælg: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Guest

                    Console.WriteLine();
                    Console.Write("Indtast fulde navn: ");
                    string name = Console.ReadLine();

                    Console.Write("Indtast firma: ");
                    string company = Console.ReadLine();

                    Guest guest = new Guest(name, company);


                    // Responsible person


                    Console.WriteLine();
                    Console.WriteLine("Vælg ansvarlig person:");

                    Console.WriteLine("1. Rene Hansen");
                    Console.WriteLine("2. Daniel Rasmussen");
                    Console.WriteLine("3. Kasper Nielsen");
                    Console.WriteLine("4. Daniel Sørensen");


                    Console.Write("Vælg: ");
                    string responsibleChoice = Console.ReadLine();

                    ResponsiblePerson responsiblePerson;

                    switch (responsibleChoice)
                    {
                        case "1":
                            responsiblePerson = new ResponsiblePerson("Rene Hansen");
                            break;

                        case "2":
                            responsiblePerson = new ResponsiblePerson("Daniel Rasmussen");
                            break;

                        case "3":
                            responsiblePerson = new ResponsiblePerson("Kasper Nielsen");
                            break;

                        case "4":
                            responsiblePerson = new ResponsiblePerson("Daniel Sørensen");
                            break;

                        default:
                            responsiblePerson = new ResponsiblePerson("Rene Hansen");
                            break;
                    }

                    // Room

                    Console.WriteLine();
                    Console.WriteLine("Vælg lokale:");

                    Console.WriteLine("1. LGS_Lokale_lille_Stue");
                    Console.WriteLine("2. LGS_Lokale_Stilling_Kantine");
                    Console.WriteLine("3. LGS_Lokale_The_Aquarium");
                    Console.WriteLine("4. LGS_Lokale_The_Bridge-East");

                    Console.Write("Vælg: ");
                    string roomChoice = Console.ReadLine();

                    Room room;

                    switch (roomChoice)
                    {
                        case "1":
                            room = new Room("LGS_Lokale_lille_Stue");
                            break;

                        case "2":
                            room = new Room("LGS_Lokale_Stilling_Kantine");
                            break;

                        case "3":
                            room = new Room("LGS_Lokale_The_Aquarium");
                            break;

                        case "4":
                            room = new Room("LGS_Lokale_The_Bridge-East");
                            break;

                        default:
                            room = new Room("LGS_Lokale_lille_Stue");
                            break;
                    }


                    // Create visit

                    Visit visit = new Visit(nextVisitNumber,
                                            guest,
                                            responsiblePerson,
                                            room);
                    Visit[] newVisits = new Visit[visits.Length + 1];

                    for (int i = 0; i < visits.Length; i++)
                    {
                        newVisits[i] = visits[i];
                    }

                    newVisits[visits.Length] = visit;

                    visits = newVisits;


                    // Reserve room

                    room.Reserve();


                    // Save visit

                    dataHandler.SaveVisits(visits);


                    // Notification

                    responsiblePerson.SendNotification();


                    // Confirmation

                    Console.WriteLine();
                    Console.WriteLine("===== Besøg oprettet =====");
                    Console.WriteLine("Navn: " + visit.Guest.Name);
                    Console.WriteLine("Firma: " + visit.Guest.Company);
                    Console.WriteLine("Ansvarlig: " + visit.ResponsiblePerson.Name);
                    Console.WriteLine("Lokale: " + visit.Room.Name);
                    Console.WriteLine("Besøgsnummer: " + visit.VisitNumber);
                    Console.WriteLine("Ankomst: " + visit.Arrival);
                    Console.WriteLine("Sikkerhedsfolder udleveret.");

                    nextVisitNumber++;

                }
                else if (choice == "2")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Ugyldigt valg.");
                }

            }
        }
    }
}
