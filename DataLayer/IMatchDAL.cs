using DTO;

namespace DataLayer
{
    public interface IMatchDAL
    {
        void AddMatch(List<MatchDTO> matches);
        bool CheckIfTournamentHasSchedule(int idTournament);
        List<MatchDTO> QueryMatch(int id);
        void AddMatchResult(int matchId, int homePlayerScore, int awayPlayerScore, int homePlayerPoints, int awayPlayerPoints);
        List<MatchDTO> SelectAllMatches();
    }
}