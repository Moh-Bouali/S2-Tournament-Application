using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BadmintonDTO : SportTypeDTO
    {
        public BadmintonDTO(string name) : base(name)
        {

        }
        public override bool ScoringRules(int player1, int player2)
        {
            if (player1 != player2)
            {
                if ((player1 <= 30 && player2 <= 30) && (player1 >= 21 || player2 >= 21) && (player1 >= 0 && player2 >= 0))
                {
                    if ((player1 == 30 && player2 == 29) || (player2 == 30 && player1 == 29))
                    {
                        if ((player1 - player2 == 1) || (player2 - player1 == 1))
                        {
                            return true;
                        }
                    }
                    else if((player1 >= 22 && player1 < 30 && player2 < 30) || (player2 >= 22 && player2 < 30 && player1 < 30))
                    {
                        if ((player1 - player2 == 2) || (player2 - player1 == 2))
                        {
                            return true;
                        }
                    }
                    else if(player1 == 21 || player2 == 21)
                    {
                        if ((player1 - player2 >= 2) || (player2 - player1 >= 2))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
