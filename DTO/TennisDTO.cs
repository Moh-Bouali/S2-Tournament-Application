using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TennisDTO : SportTypeDTO
    {
        public TennisDTO(string name) : base(name)
        {

        }
        public override bool ScoringRules(int player1, int player2)
        {
            if(player1 != player2)
            {
                if ((player1 <= 5 && player2 <= 5) && (player1 == 3 || player2 == 3) && (player1 >= 0 && player2 >= 0))
                {
                    if ((player1 - player2 == 2) || (player2 - player1 == 2) || (player1 - player2 == 1) || (player2 - player1 == 1))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
