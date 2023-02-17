using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffMemberDTO : PersonDTO
    {
        public StaffMemberDTO(string name, int id, string password, string salt) : base(name, id, password, salt)
        {

        }
    }
}
