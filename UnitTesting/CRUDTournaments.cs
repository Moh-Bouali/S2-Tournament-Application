using DataLayer;
using DesktopApp_Synthesis_Assignment_DuelSyns.Inc;
using DTO;
using LogicLayer;
using MySql.Data.MySqlClient;

namespace UnitTesting
{
    [TestClass]
    public class CRUDTournaments
    {
        SportTypeDTO badminton1 = new BadmintonDTO("Badminton");
        SportTypeDTO Chess1 = new ChessDTO("Tennis");
        
        [TestMethod]
        public void InsertData()
        {
            MockTournament mockTournament = new MockTournament();
            //Here we test if we can insert data into the database
            TournamentDTO tournament = new TournamentDTO("InsertBadmintonTest", 99, DateTime.Now.AddDays(10), DateTime.Now.AddDays(14), 8, 4, badminton1, "Bucharest");
            Assert.AreEqual(1, mockTournament.AddTournament(tournament));
        }
        [TestMethod]
        public void ReturnList()
        {
            //Here we test if we can insert data into the database
            MockTournament mockTournament = new MockTournament();
            Assert.AreEqual(3, mockTournament.SelectAllTournaments().Count);
        }
        [TestMethod]
        public void DeletingTournament()
        {
            //Here we test if we can fill the persons list with the information that's in the database
            MockTournament mockTournament = new MockTournament();
            Assert.AreEqual(1, mockTournament.DeleteTournament(51));
        }
        [TestMethod]
        public void UpdatingTournament()
        {
            //Here we test if we can delete data from the database
            MockTournament mockTournament = new MockTournament();
            TournamentDTO upDatedTournament = new TournamentDTO("updatedTest", 52, DateTime.Now.AddDays(10), DateTime.Now.AddDays(14), 6, 4, Chess1, "Amsterdam");
            Assert.AreEqual(6, mockTournament.UpdateTournament(upDatedTournament));
        }
    }
}