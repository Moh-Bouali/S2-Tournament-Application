using DataLayer;
using DesktopApp_Synthesis_Assignment_DuelSyns.Inc;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website_DuelSyns.Inc_Synthesis_2022.Pages
{
    public class LeaderBoardModel : PageModel
    {
        ManagingTournament managingTournament;
        //ManagingMatch managingMatch;
        ManagingPerson managingPerson;
        public List<Player>? PlayersPerTournament { get; set; }
        //public List<Tournament> TournamentList { get; set; }
        public void OnGet(int id)
        {
            managingTournament = new ManagingTournament(new TournamentDAL());
            managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            foreach (Tournament tournament in managingTournament.GetAllTouanaments().ToList())
            {
                if (tournament.TournamentId == id)
                {
                    PlayersPerTournament = managingPerson.GetPlayersPerTournamentId(tournament.TournamentId);
                    break;
                }
            }
            foreach(Player player in PlayersPerTournament)
            {
                player.Points = managingPerson.ReturnTotalPlayerPoints(player.ID, id);
            }
            PlayersPerTournament.Sort();

            for (int i = 0; i < PlayersPerTournament.Count; i++)
            {
                if(i != 0)
                {
                    if (PlayersPerTournament[i].Points == PlayersPerTournament[i - 1].Points)
                    {
                        PlayersPerTournament[i].Rank = PlayersPerTournament[i - 1].Rank;
                    }
                    else
                    {
                        PlayersPerTournament[i].Rank = i+1;
                    }
                }
                else
                {
                    PlayersPerTournament[i].Rank = 1;
                }
            }
        }
    }
}
