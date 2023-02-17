using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MatchDTO
    {
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
        public MatchDTO(int matchId, int tournamentId, int homePlayerId, int awayPlayerId, int homePlayerScore, int awayPlayerScore, int homePlayerPoints, int awayPlayerPoints)
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
    }
}
