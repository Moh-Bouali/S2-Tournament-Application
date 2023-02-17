using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TournamentDTO
    {
        public string? TournamentName { get; set; }
        public int TournamentId { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxPlayers { get; set; }
        public int MinPlayers { get; set; }
        public SportTypeDTO SportType { get; set; }
        public string Location { get; set; }    
        public int RegisteredPlayers { get; set; }
        public TournamentDTO(string? tournamentName, int tournamentId, DateTime startingDate, DateTime endDate, int maxPlayers, int minPlayers, SportTypeDTO sportType, string Location)
        {
            TournamentName = tournamentName;
            TournamentId = tournamentId;
            StartingDate = startingDate;
            EndDate = endDate;
            this.MaxPlayers = maxPlayers;
            this.MinPlayers = minPlayers;
            this.SportType = sportType;
            this.Location = Location;
        }
    }
}
