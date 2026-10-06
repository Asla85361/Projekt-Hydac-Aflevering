using Project_Hydac_Final;

namespace TestProjectHydac
{
    [TestClass]
    public sealed class TestProjectHydac
    {
        [TestMethod]
        public void VisitConstructor()
        {
            // Arrange

            Guest guest = new Guest("Jan Jensen","UCL");
            ResponsiblePerson resPerson = new ResponsiblePerson("Peter Hansen");
            Room room = new Room("LGS_Lokale_lille_Stue");

            // Act

            Visit visit = new Visit(1, guest, resPerson, room);

            // Assert

            Assert.AreEqual(1, visit.VisitNumber); //Take the VisitNumber from the created visit object and compare it with 1.
            Assert.AreEqual(guest, visit.Guest);
            Assert.AreEqual(resPerson, visit.ResponsiblePerson);
            Assert.AreEqual(room, visit.Room);
        }
    }
}
