using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp_Synthesis_Assignment_DuelSyns.Inc
{
    public class Staff_member : Person
    {
        public Staff_member(string name, int id, string password, string salt) : base(name, id ,password, salt)
        {

        }
        public Staff_member(PersonDTO dto) : base(dto.Name, dto.ID, dto.Password, dto.Salt)
        {

        }
        public override string GetInfo()
        {
            return $"Secretary : {this.Name}, ID : {this.id}";
        }
    }
}
