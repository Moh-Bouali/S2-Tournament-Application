using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ManagingTournamentDTO
    {
        public ManagingTournamentDTO()
        {

        }
        public SportTypeDTO sportType(string sportType)
        {
            if (sportType == "Tennis")
            {
                SportTypeDTO sport = new TennisDTO("Tennis");
                return sport;
            }
            else if (sportType == "Badminton")
            {
                SportTypeDTO sport = new BadmintonDTO("Badminton");
                return sport;
            }
            else if (sportType == "Chess")
            {
                SportTypeDTO sport = new ChessDTO("Chess");
                return sport;
            }
            return null;
        }
    }
}
