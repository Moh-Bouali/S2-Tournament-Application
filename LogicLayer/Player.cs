using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp_Synthesis_Assignment_DuelSyns.Inc
{
    public class Player : Person, IComparable<Player>
    {
        public int Rank { get; set; }
        public int Points { get; set; }
        public Player(int age, string name, int id, string password, string salt) : base(age, name, id, password, salt)
        {

        }

        public Player(PersonDTO dto) : base(dto.Age, dto.Name, dto.ID, dto.Password, dto.Salt)
        {

        }
        public override string GetInfo()
        {
            return $"Player : {this.name}, Age : {this.age}, ID : {this.id}";
        }
        public int CompareTo(Player? anotherPlayer)
        {
            if (anotherPlayer.Points > Points)
            {
                return 1;
            }
            else if (anotherPlayer.Points < Points)
            {
                return -1;
            }
            return 0;
        }
    }
}
