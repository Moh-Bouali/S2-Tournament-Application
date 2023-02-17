using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChessDTO : SportTypeDTO
    {
        public ChessDTO(string name) : base(name)
        {

        }
        public override bool ScoringRules(int player1, int player2)
        {
            if (player1 != player2)
            {
                if ((player1 == 1 || player2 == 1) && (player1 >= 0 && player2 >= 0))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
