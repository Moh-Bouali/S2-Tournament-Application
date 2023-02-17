using DataLayer;
using DTO;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp_Synthesis_Assignment_DuelSyns.Inc
{
    public class ManagingPerson
    {
        public IPlayerDAL playerDAL;
        public IStaffDAL staffDAL;
        private List<Person> persons;
        private List<Player> playersPerTournamentId;

        public ManagingPerson(IPlayerDAL playerDAL, IStaffDAL staffDAL)
        {
            this.playerDAL = playerDAL;
            this.staffDAL = staffDAL;
            persons = new List<Person>();
            playersPerTournamentId = new List<Player>();
            QueryAllPlayers();
            QueryAllStaff();  
        }
        //Returns the list of persons
        public List<Person> publicPersonsList { get => this.persons; }
        //This is specific to a player
        public Player GetPlayer(int id)
        {
            foreach(PersonDTO playerDTO in playerDAL.SelectAllPlayers())
            {
                if (playerDTO.ID == id)
                {
                    Player player = new Player(playerDTO);
                    return player;
                }
            }
            return null;
        }
        public string GetPlayerName(int id)
        {
            foreach(Player player in persons)
            {
                if (player.ID == id)
                {
                    return player.Name;
                }
            }
            return string.Empty;
        }
        public Person GetStaff(int id)
        {
            foreach (PersonDTO staffDTO in staffDAL.SelectAllStaffMembers())
            {
                if (staffDTO.ID == id)
                {
                    Person staffMember = new Staff_member(staffDTO);
                    return staffMember;
                }
            }
            return null;
        }
        //This is to check the login credentials for the website
        public bool CheckLoginForPlayer(int id, string password)
        {
            if (playerDAL.Login(id, password))
            {
                return true;
            }
            return false;
        }
        //This is to always update the persons list
        public void QueryAllPlayers()
        {
            foreach(PersonDTO playerdto in playerDAL.SelectAllPlayers())
            {
                Person player = new Player(playerdto);
                persons.Add(player);    
            } 
        }
        public void QueryAllStaff()
        {
            foreach (PersonDTO staffdto in staffDAL.SelectAllStaffMembers())
            {
                Person staff = new Staff_member(staffdto);
                persons.Add(staff);
            }
            
        }
        public void AddingPerson(Person person)
        {
            if (person is Player)
            {
                persons.Add(person);
                PersonDTO playerDTO = new PlayerDTO(person.Age, person.Name, person.ID, person.Password, person.Salt);
                playerDAL.AddPlayer(playerDTO);
            }
            else
            {
                persons.Add(person);
                PersonDTO staffDTO = new StaffMemberDTO(person.Name, person.ID, person.Password, person.Salt);
                staffDAL.AddStaff(staffDTO);
            }
        }
        public void DeletePerson(Person person)
        {
            if (person is Player)
            {
                PersonDTO playerDTO = new PlayerDTO(person.Age, person.Name, person.ID, person.Password, person.Salt);
                playerDAL.DeletePlayer(playerDTO);
            }
            else
            {
                PersonDTO staffDTO = new StaffMemberDTO(person.Name, person.ID, person.Password, person.Salt);
                staffDAL.DeleteStaff(staffDTO);
            }
        }
        public string GetName(int id)
        {
            foreach(Person person in persons)
            {
                if (person.ID == id)
                {
                    return person.Name;
                }
            }
            return null;
        }
        public string GetSalt(int id)
        {
            return playerDAL.GetSaltOfPlayer(id);
        }
        public void AddPlayerToTournament(int idPlayer, int idTournament)
        {
            playerDAL.AddPlayerToTournament(idPlayer, idTournament);
        }
        public bool CheckIfPlayerAlreadyRegistered(int idTournament, int idPlayer)
        {
            return playerDAL.CheckIfPlayerAlreadyRegistered(idTournament, idPlayer);
        }
        public List<Player> GetPlayersPerTournamentId(int tournamendID)
        {
            foreach (PlayerDTO playerdto in playerDAL.GetPlayersPerTournamendId(tournamendID))
            {
                if(playerdto is PlayerDTO)
                {
                    Player player = new Player(playerdto);
                    playersPerTournamentId.Add(player);
                }
            }
            return playersPerTournamentId;
        }
        public int CountOfPlayers(int idTournament)
        {
            return playerDAL.GetCountOfParticipatingPlayers(idTournament);
        }
        public int GetPlayerTournamentId(int idPlayer)
        {
            return playerDAL.GetPlayersTournamentId(idPlayer);
        }
        public int ReturnTotalPlayerPoints(int idPlayer, int idTournament)
        {
            return playerDAL.GetLeaderBoardOfPlayersHome(idPlayer, idTournament) + playerDAL.GetLeaderBoardOfPlayersAway(idPlayer, idTournament);
        }
    }
}
