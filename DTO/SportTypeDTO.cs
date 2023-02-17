using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class SportTypeDTO
    {
        protected string? name;
        public String? Name { get => name; }
        public SportTypeDTO(string? name)
        {
            this.name = name;
        }
        public virtual bool ScoringRules(int player1, int player2)
        {
            return false;
        }
    }
}
