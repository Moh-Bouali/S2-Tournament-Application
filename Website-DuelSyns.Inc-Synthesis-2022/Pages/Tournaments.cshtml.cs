using DataLayer;
using DesktopApp_Synthesis_Assignment_DuelSyns.Inc;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website_DuelSyns.Inc_Synthesis_2022.Pages
{
    [Authorize]
    public class TournamentsModel : PageModel
    {
        [BindProperty]
        public bool AlreadyRegistered { get; set; }
        [BindProperty]
        public List<Tournament>? tournamentList { get; set; }
        public string Message { get; set; }

        public List<Tournament>? availableTournaments = new List<Tournament>();
        public void OnGet()
        {
            ManagingTournament managingTournament = new ManagingTournament(new TournamentDAL());
            ManagingPerson managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            tournamentList = managingTournament.GetAllTouanaments();
            foreach(Tournament tournament in tournamentList)
            {
                tournament.RegisteredPlayers = managingPerson.CountOfPlayers(tournament.TournamentId);
                if(!managingPerson.CheckIfPlayerAlreadyRegistered(tournament.TournamentId, Convert.ToInt32(User?.FindFirst("UserId").Value)) && (tournament.RegisteredPlayers < tournament.MaxPlayers) && (DateTime.Now.AddDays(7) < tournament.StartingDate))
                {
                    availableTournaments.Add(tournament);
                }
            }
        }
        public IActionResult OnPost(int id)
        {
            ManagingPerson managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            managingPerson.AddPlayerToTournament(Convert.ToInt32(User?.FindFirst("UserId").Value), id);
            Message = "Registered";
            HttpContext.Session.SetString("Message", "Registered !");
            return Page();
        }
    }
}
