using DataLayer;
using DesktopApp_Synthesis_Assignment_DuelSyns.Inc;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website_DuelSyns.Inc_Synthesis_2022.Pages
{
    [Authorize]
    public class TournamentInfoModel : PageModel
    {
        public List<Tournament> TournamentList { get; set; }
        public List<Player> PlayersPerTournament { get; set; }
        ManagingTournament managingTournament;
        ManagingPerson managingPerson;
        public void OnGet()
        {
            TournamentList = new List<Tournament>();
            managingTournament = new ManagingTournament(new TournamentDAL());
            managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            TournamentList = managingTournament.GetAllTouanaments();
            foreach(Tournament tournament in TournamentList)
            {
                tournament.RegisteredPlayers = managingPerson.CountOfPlayers(tournament.TournamentId);
            }
        }
        public IActionResult OnPost(int Id)
        {
            return RedirectToPage("./LeaderBoard", new { id = Id });
        }
        public IActionResult OnPostDetail(int Id)
        {
            return RedirectToPage("./DetailsPage", new { id = Id });
        }
    }
}
