using DTO;

namespace DataLayer
{
    public interface ITournamentDAL
    {
        void AddTournament(TournamentDTO tournamentDTO);
        List<TournamentDTO> SelectAllTournaments();
        void UpdateTournament(TournamentDTO tournamentDTO);
        void DeleteTournament(int id);
    }
}