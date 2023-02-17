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
    public class Tournament
    {
        public string? TournamentName { get; set; }
        public int TournamentId { get; set; }
        public DateTime StartingDate { get; set; }  
        public DateTime EndDate { get; set; }   
        public int MaxPlayers { get; set; }
        public int MinPlayers { get; set; }
        public int RegisteredPlayers { get; set; }
        public SportTypeDTO SportTypeDTO { get; set; }
        public string WinnerName { get; set; }
        public int WinnerPoints { get; set; }   
        public int SecondPlacePoints { get; set; }
        public string SecondPlaceName { get; set; }
        public int ThirdPlacePoints { get; set; }
        public string ThirdName { get; set; }
        public string Location { get; set; }    

        public Tournament(string? tournamentName, int tournamentId, DateTime startingDate, DateTime endDate, int maxPlayers, int minPlayers, SportTypeDTO sportType, string Location)
        {
            TournamentName = tournamentName;
            TournamentId = tournamentId;
            StartingDate = startingDate;
            EndDate = endDate;
            MaxPlayers = maxPlayers;
            MinPlayers = minPlayers;
            this.SportTypeDTO = sportType;
            this.Location = Location;
        }
        public Tournament(TournamentDTO dto)
        {
            TournamentName = dto.TournamentName;
            TournamentId = dto.TournamentId;
            StartingDate = dto.StartingDate;
            EndDate = dto.EndDate;
            MaxPlayers = dto.MaxPlayers;
            MinPlayers = dto.MinPlayers;
            this.SportTypeDTO = dto.SportType;
            this.Location = dto.Location;
        }
        public string GetInfo()
        {
            string? sportTypeName = this.SportTypeDTO.Name;
            return $"Tournament: {TournamentId}, {TournamentName}, Max Players: {MaxPlayers}, Min Players: {MinPlayers}, From: {StartingDate.ToString("dd/MM/yyyy")}, until: {EndDate.ToString("dd/MM/yyyy")}, {sportTypeName}, {Location}";
        }
    }
}
