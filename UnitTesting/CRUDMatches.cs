using DataLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class CRUDMatches
    {
        [TestMethod]
        public void InsertData()
        {
            List<MatchDTO> matchDTOs = new List<MatchDTO>();    
            MockMatch mockMatch = new MockMatch();
            //Here we test if we can insert data into the database
            MatchDTO matchDTO = new MatchDTO(1, 99, 2, 3, 21, 19, 1,0);
            matchDTOs.Add(matchDTO);
            Assert.AreEqual(1, mockMatch.AddMatch(matchDTOs));
        }
        [TestMethod]
        public void InsertintMatchResult()
        {
            //Here we test if we can insert data into the database
            MockMatch mockMatch = new MockMatch();
            Assert.AreEqual(1, mockMatch.AddMatchResult(1, 23, 21, 1, 0));
        }
        [TestMethod]
        public void CheckingTournamtnSchedule()
        {
            //Here we test if we can fill the persons list with the information that's in the database
            MockMatch mockMatch = new MockMatch();
            Assert.IsTrue( mockMatch.CheckIfTournamentHasSchedule(51));
        }
        [TestMethod]
        public void ReturnListOfMatches()
        {
            //Here we test if we can fill the persons list with the information that's in the database
            MockMatch mockMatch = new MockMatch();
            Assert.AreEqual(3, mockMatch.SelectAllMatches().Count);
        }
    }
}
