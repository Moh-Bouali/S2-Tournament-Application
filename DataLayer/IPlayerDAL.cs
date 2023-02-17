
using DTO;

namespace DataLayer
{
    public interface IPlayerDAL
    {
        List<PersonDTO> SelectAllPlayers();
        void AddPlayer(PersonDTO person);
        void DeletePlayer(PersonDTO playerDTO);
        bool Login(int id, string password);
        string GetSaltOfPlayer (int id);
        void AddPlayerToTournament(int idPlayer, int idTournament);
        bool CheckIfPlayerAlreadyRegistered(int idTournament, int playerId);
        List<PlayerDTO> GetPlayersPerTournamendId(int tournameniD);
        int GetCountOfParticipatingPlayers(int id);
        int GetPlayersTournamentId(int idPlayer);
        int GetLeaderBoardOfPlayersAway(int idPlayerAway, int idTournament);
        int GetLeaderBoardOfPlayersHome(int idPlayerHome, int idTournament);
    }
}