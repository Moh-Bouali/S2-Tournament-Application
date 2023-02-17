using DataLayer;
using DTO;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class Assertion
    {
        ManagingTournament managingTournament = new ManagingTournament(new TournamentDAL());
        [TestMethod]
        public void CreatingTournamentWithOnePlayer()
        {
            int testNumber = managingTournament.RulesOfTournament(1, 1, DateTime.Now.AddDays(8), DateTime.Now.AddDays(12));
            Assert.AreEqual(testNumber, 1);
        }
        [TestMethod]
        public void MaxPlayersLessThanMin()
        {
            int testNumber = managingTournament.RulesOfTournament(2, 4, DateTime.Now.AddDays(8), DateTime.Now.AddDays(12));
            Assert.AreEqual(testNumber, 2);
        }
        [TestMethod]
        public void StartDateEqualsEndDate()
        {
            DateTime startDate = DateTime.Now.AddDays(8);
            DateTime endDate = startDate;
            int testNumber = managingTournament.RulesOfTournament(4, 2, startDate, endDate);
            Assert.AreEqual(testNumber, 3);
        }
        [TestMethod]
        public void EndDateSmallerThanStart()
        {
            int testNumber = managingTournament.RulesOfTournament(4, 2, DateTime.Now.AddDays(10), DateTime.Now.AddDays(8));
            Assert.AreEqual(testNumber, 4);
        }
        [TestMethod]
        public void StartDateOrEndDateBeforeToday()
        {
            int testNumber = managingTournament.RulesOfTournament(4, 2, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(8));
            Assert.AreEqual(testNumber, 5);
        }
        [TestMethod]
        public void MaxPlayersNotMoreThanMax()
        {
            int testNumber = managingTournament.RulesOfTournament(12, 2, DateTime.Now.AddDays(8), DateTime.Now.AddDays(10));
            Assert.AreEqual(testNumber, 6);
        }
        [TestMethod]
        public void StartDateLessThanWeek()
        {
            int testNumber = managingTournament.RulesOfTournament(8, 2, DateTime.Now.AddDays(6), DateTime.Now.AddDays(10));
            Assert.AreEqual(testNumber, 7);
        }
        [TestMethod]
        public void OnePointDifferenceBadminton()
        {
            SportTypeDTO sportTypeDTO = new BadmintonDTO("Badminton");
            Assert.IsFalse(sportTypeDTO.ScoringRules(21, 20));
        
        }
        [TestMethod]
        public void LessThan21Badminton()
        {
            SportTypeDTO sportTypeDTO = new BadmintonDTO("Badminton");
            Assert.IsFalse(sportTypeDTO.ScoringRules(20, 18));
        }
        [TestMethod]
        public void TwoPointDifferenceThirtyBadminton()
        {
            SportTypeDTO sportTypeDTO = new BadmintonDTO("Badminton");
            Assert.IsFalse(sportTypeDTO.ScoringRules(30, 28));
        }
        [TestMethod]
        public void HigherThanThirtyBadminton()
        {
            SportTypeDTO sportTypeDTO = new BadmintonDTO("Badminton");
            Assert.IsFalse(sportTypeDTO.ScoringRules(31, 29));
        }
        [TestMethod]
        public void OnePointDifferenceHigherThan21Badminton()
        {
            SportTypeDTO sportTypeDTO = new BadmintonDTO("Badminton");
            Assert.IsFalse(sportTypeDTO.ScoringRules(24, 23));
        }
        [TestMethod]
        public void DrawBadminton()
        {
            SportTypeDTO sportTypeDTO = new BadmintonDTO("Badminton");
            Assert.IsFalse(sportTypeDTO.ScoringRules(30, 30));
        }
        [TestMethod]
        public void LessThanZeroBadminton()
        {
            SportTypeDTO sportTypeDTO = new BadmintonDTO("Badminton");
            Assert.IsFalse(sportTypeDTO.ScoringRules(-2, 30));
        }
        [TestMethod]
        public void MoreThanThreeTennis()
        {
            SportTypeDTO sportTypeDTO = new TennisDTO("Tennis");
            Assert.IsFalse(sportTypeDTO.ScoringRules(4, 1));
        }
        [TestMethod]
        public void TwoSetsOnlyTennis()
        {
            SportTypeDTO sportTypeDTO = new TennisDTO("Tennis");
            Assert.IsFalse(sportTypeDTO.ScoringRules(2, 0));
        }
        [TestMethod]
        public void LessZeroTennis()
        {
            SportTypeDTO sportTypeDTO = new TennisDTO("Tennis");
            Assert.IsFalse(sportTypeDTO.ScoringRules(-1, 1));
        }
        [TestMethod]
        public void DrawTennis()
        {
            SportTypeDTO sportTypeDTO = new TennisDTO("Tennis");
            Assert.IsFalse(sportTypeDTO.ScoringRules(2, 2));
        }
        [TestMethod]
        public void MoreThanOneChess()
        {
            SportTypeDTO sportTypeDTO = new ChessDTO("Chess");
            Assert.IsFalse(sportTypeDTO.ScoringRules(2, 0));
        }
        [TestMethod]
        public void LessThanOneChess()
        {
            SportTypeDTO sportTypeDTO = new ChessDTO("Chess");
            Assert.IsFalse(sportTypeDTO.ScoringRules(-1, 0));
        }
        [TestMethod]
        public void DrawChess()
        {
            SportTypeDTO sportTypeDTO = new ChessDTO("Chess");
            Assert.IsFalse(sportTypeDTO.ScoringRules(1, 1));
        }
    }
}
