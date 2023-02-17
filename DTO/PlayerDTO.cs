using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PlayerDTO : PersonDTO
    {
        public PlayerDTO(int age, string name, int id, string password, string salt) : base(age, name, id, password, salt)
        {

        }
    }
}
