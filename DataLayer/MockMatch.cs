using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MockMatch
    {
        private List<MatchDTO> matchDTOs = new List<MatchDTO>();
        public MockMatch()
        {
            matchDTOs = new List<MatchDTO>();
            matchDTOs.Add(new MatchDTO(99, 50, 55, 56, 21, 19, 1, 0));
            matchDTOs.Add(new MatchDTO(100, 51, 57, 58, 3, 2, 1, 0));
            matchDTOs.Add(new MatchDTO(101, 52, 59, 60, 0, 1, 0, 1));
        }
        public int AddMatch(List<MatchDTO> matches)
        {
            matchDTOs.AddRange(matches);
            return 1;
        }
        public int AddMatchResult(int matchId, int homePlayerScore, int awayPlayerScore, int homePlayerPoints, int awayPlayerPoints)
        {
            MatchDTO matchDTO = new MatchDTO(matchId, 0, 1, 2, homePlayerScore, awayPlayerScore, homePlayerPoints, awayPlayerPoints);
            return matchDTO.MatchId;
        }
        public bool CheckIfTournamentHasSchedule(int idTournament)
        {
            foreach(MatchDTO matchDTO in matchDTOs)
            {
                if (matchDTO.TournamentId == idTournament)
                {
                    return true;
                }
            }
            return false;
        }
        public List<MatchDTO> QueryMatch(int id)
        {
            throw new NotImplementedException();
        }
        public List<MatchDTO> SelectAllMatches()
        {
            return matchDTOs;
        }
    }
}
