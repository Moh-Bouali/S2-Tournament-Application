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
    public class Match
    {
        ManagingPerson managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
        protected int homePlayerScore;
        protected int awayPlayerScore;
        protected int homePlayerPoints;
        protected int awayPlayerPoints;
        protected int matchId;
        protected int tournamentId;
        protected int homePlayerId;
        protected int awayPlayerId;

        public int MatchId { get => matchId; set => matchId = value; }
        public int TournamentId { get => tournamentId; set => tournamentId = value; }
        public int HomePlayerId { get => homePlayerId; set => homePlayerId = value; }
        public int AwayPlayerId { get => awayPlayerId; set => awayPlayerId = value; }
        public int HomePlayerScore { get => homePlayerScore; set => homePlayerScore = value; }
        public int AwayPlayerScore { get => awayPlayerScore; set => awayPlayerScore = value; }
        public int HomePlayerPoints { get => homePlayerPoints; set => homePlayerPoints = value; }
        public int AwayPlayerPoints { get => awayPlayerPoints; set => awayPlayerPoints = value; }
        public Match(int matchId, int tournamentId, int homePlayerId, int awayPlayerId, int homePlayerScore, int awayPlayerScore, int homePlayerPoints, int awayPlayerPoints)
        {
            this.matchId = matchId;
            this.tournamentId = tournamentId;
            this.homePlayerId = homePlayerId;
            this.awayPlayerId = awayPlayerId;
            this.homePlayerScore = homePlayerScore;
            this.awayPlayerScore = awayPlayerScore;
            this.homePlayerPoints = homePlayerPoints;
            this.awayPlayerPoints = awayPlayerPoints;
        }
        public Match (MatchDTO dto)
        {
            this.matchId = dto.MatchId;
            this.tournamentId = dto.TournamentId;
            this.homePlayerId = dto.HomePlayerId;
            this.awayPlayerId = dto.AwayPlayerId;
            this.homePlayerScore = dto.HomePlayerScore;
            this.awayPlayerScore = dto.AwayPlayerScore;
            this.homePlayerPoints = dto.HomePlayerPoints;
            this.awayPlayerPoints = dto.AwayPlayerPoints;
        }

        public string GetInfo()
        {
            string player1 = managingPerson.GetName(this.HomePlayerId);
            string player2 = managingPerson.GetName(this.awayPlayerId);

            return $"{player1} vs {player2}";
        }
    }
}
