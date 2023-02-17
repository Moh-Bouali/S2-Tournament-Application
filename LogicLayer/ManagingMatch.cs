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
    public class ManagingMatch
    {
        public IMatchDAL matchDAL;
        private List<Match> tournamentMatches;
        private List<Match> allTournamentMatches;
        private List<MatchDTO> matches;

        public ManagingMatch(IMatchDAL matchDAL)
        {
            this.matchDAL = matchDAL;
            tournamentMatches = new List<Match>();
            matches = new List<MatchDTO>();
            allTournamentMatches = new List<Match>();
            QueryAllMatches();
        }
        public List<Match> publicMatchesList { get => this.tournamentMatches; }
        public void QueryMatches(int id)
        {
            tournamentMatches.Clear();
            foreach (MatchDTO matchDTO in matchDAL.QueryMatch(id))
            {
                if (matchDTO.HomePlayerId != 0 && matchDTO.AwayPlayerId != 0)
                {
                    Match match = new Match(matchDTO.MatchId, matchDTO.TournamentId, matchDTO.HomePlayerId, matchDTO.AwayPlayerId, matchDTO.HomePlayerScore, matchDTO.AwayPlayerScore, matchDTO.HomePlayerPoints, matchDTO.AwayPlayerPoints);
                    tournamentMatches.Add(match);
                }
            }
        }
        public void QueryAllMatches()
        {
            foreach (MatchDTO matchDTO in matchDAL.SelectAllMatches())
            {
                Match match = new Match(matchDTO);
                allTournamentMatches.Add(match);
            }
        }
        public void CreateSchedulingForMatches(List<Player> listPlayers, Tournament tournament)
        {
            //Got some of this code from the following website : https://www.generacodice.com/en/articolo/311095/round-robin-tournament-algorithm-in-c
            Player playerBye = new Player(22, "Bye", 0, "Bye", "Bye");
            if (listPlayers.Count % 2 != 0)
            {
                listPlayers.Add(playerBye);
            }

            int numGames = listPlayers.Count - 1;
            int halfSize = listPlayers.Count / 2;

            List<Person> players = new List<Person>();

            players.AddRange(listPlayers); // Copy all the elements.
            players.RemoveAt(0); // To exclude the first player.

            int playersSize = players.Count;
            for (int day = 0; day < numGames; day++)
            {
                int playerIdx = day % playersSize;
                MatchDTO match = new MatchDTO(0, tournament.TournamentId, players[playerIdx].ID, listPlayers[0].ID, 0, 0, 0, 0);

                matches.Add(match);//insert them as a list

                for (int idx = 1; idx < halfSize; idx++)
                {
                    int firstPlayer = (day + idx) % playersSize;
                    int secondPlayer = (day + playersSize - idx) % playersSize;
                    MatchDTO match2 = new MatchDTO(0, tournament.TournamentId, players[firstPlayer].ID, players[secondPlayer].ID,0,0,0,0);

                        matches.Add(match2);//insert them as a list

                }
            }
        }
        public void AddMatchScehduleToDataBase()
        {
            matchDAL.AddMatch(matches);
        }
        public bool HasSchedule(int idTournament)
        {
            return matchDAL.CheckIfTournamentHasSchedule(idTournament);
        }
        public List<Match> GetAllMatches()
        {
            return tournamentMatches;
        }
        public void AddMatchResult(int matchId, int homePlayerScore, int awayPlayerScore, int homePlayerPoints, int awayPlayerPoints)
        {
            matchDAL.AddMatchResult(matchId, homePlayerScore, awayPlayerScore, homePlayerPoints, awayPlayerPoints);
        }
    }
}
