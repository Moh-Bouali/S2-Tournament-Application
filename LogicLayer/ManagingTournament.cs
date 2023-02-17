using DataLayer;
using DesktopApp_Synthesis_Assignment_DuelSyns.Inc;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class ManagingTournament
    {
        public ITournamentDAL tournamentDAL;
        private List<Tournament> tournamentList;
        public ManagingTournament(ITournamentDAL tournamentDAL)
        {
            this.tournamentDAL = tournamentDAL;
            tournamentList = new List<Tournament>();
            QueryListTournaments();
        }
        public List<Tournament> publicTournamentsList { get => this.tournamentList; }
        public void AddTournament(Tournament tournament)
        {
            tournamentList.Add(tournament);
            TournamentDTO tournamentDTO = new TournamentDTO(tournament.TournamentName, (int)tournament.TournamentId,tournament.StartingDate,tournament.EndDate, (int)tournament.MaxPlayers, (int)tournament.MinPlayers, tournament.SportTypeDTO, tournament.Location);
            tournamentDAL.AddTournament(tournamentDTO);
        }
        public void QueryListTournaments()
        {
            foreach (TournamentDTO tournamentDTO in tournamentDAL.SelectAllTournaments())
            {
                Tournament tournament = new Tournament(tournamentDTO);
                tournamentList.Add(tournament);
            }
        }
        public List<Tournament> GetAllTouanaments()
        {
            return tournamentList;
        }
        public Tournament GetTournament(int id)
        {
            foreach (TournamentDTO tournamentDTO in tournamentDAL.SelectAllTournaments())
            {
                if (tournamentDTO.TournamentId == id)
                {
                    Tournament tournament = new Tournament(tournamentDTO);
                    return tournament;
                }
            }
            return null;
        }
        public void UpdateTournament(Tournament tournament)
        {
            TournamentDTO tournamentDTO = new TournamentDTO(tournament.TournamentName, tournament.TournamentId, tournament.StartingDate, tournament.EndDate, tournament.MaxPlayers, tournament.MinPlayers, tournament.SportTypeDTO, tournament.Location);
            tournamentDAL.UpdateTournament(tournamentDTO);
        }
        public void DeleteTournaments(int id)
        {
            tournamentDAL.DeleteTournament(id);
        }
        public int RulesOfTournament(int maxPlayers, int minPlayers, DateTime startDate, DateTime endDate)
        {
            if (maxPlayers < 2 || minPlayers < 2 )
            {
                return 1;
            }
            if(maxPlayers < minPlayers)
            {
                return 2;
            }
            if (startDate == endDate)
            {
                return 3;
            }
            if (endDate < startDate)
            {
                return 4;
            }
            if(startDate < DateTime.Today || endDate < DateTime.Today)
            {
                return 5;
            }
            if(maxPlayers > 10)
            {
                return 6;
            }
            if(DateTime.Today.AddDays(7) > startDate)
            {
                return 7;
            }
            return 0;
        }
        public SportTypeDTO SportType(string sportType)
        {
            if (sportType == "TENNIS")
            {
               SportTypeDTO sport = new TennisDTO("Tennis");
               return sport;
            }
            else if(sportType == "BADMINTON")
            {
                SportTypeDTO sport = new BadmintonDTO("Badminton");
                return sport;
            }
            else if(sportType == "CHESS")
            {
                SportTypeDTO sport = new ChessDTO("Chess");
                return sport;
            }
            return null;
        }
    }
}
