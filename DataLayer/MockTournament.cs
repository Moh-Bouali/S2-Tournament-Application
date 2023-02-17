using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MockTournament
    {
        private List<TournamentDTO> tournaments;
        SportTypeDTO badminton1 = new BadmintonDTO("Badminton");
        SportTypeDTO tennis1 = new TennisDTO("Tennis");
        SportTypeDTO Chess1 = new ChessDTO("Tennis");

        public MockTournament()
        {
            tournaments = new List<TournamentDTO>();
            tournaments.Add(new TournamentDTO("TestBadminton1", 50, DateTime.Now.AddDays(10), DateTime.Now.AddDays(14), 6, 4, badminton1, "Eindhoven"));
            tournaments.Add(new TournamentDTO("TestTennis1", 51, DateTime.Now.AddDays(10), DateTime.Now.AddDays(14), 4, 2, tennis1, "Prague"));
            tournaments.Add(new TournamentDTO("TestChess1", 52, DateTime.Now.AddDays(10), DateTime.Now.AddDays(14), 8, 6, Chess1, "Amsterdam"));
        }
        public int AddTournament(TournamentDTO tournamentDTO)
        {
            tournaments.Add(tournamentDTO);
            return 1;
        }
        public int DeleteTournament(int id)
        {
            foreach (TournamentDTO tournament in tournaments)
            {
                if (tournament.TournamentId == id)
                {
                    tournaments.Remove(tournament);
                    return 1;
                }
            }
            return 0;
        }
        public List<TournamentDTO> SelectAllTournaments()
        {
            return tournaments;
        }
        public int UpdateTournament(TournamentDTO tournamentDTO)
        {
            foreach(TournamentDTO tournament in tournaments)
            {
                if (tournament.TournamentId == tournamentDTO.TournamentId)
                {
                    tournaments[tournaments.IndexOf(tournament)] = tournamentDTO;
                    return tournamentDTO.MaxPlayers;
                }
            }
            return 0;
        }
    }
}
