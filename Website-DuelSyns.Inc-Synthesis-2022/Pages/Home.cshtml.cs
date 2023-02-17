using DataLayer;
using DesktopApp_Synthesis_Assignment_DuelSyns.Inc;
using LogicLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Website_DuelSyns.Inc_Synthesis_2022.Pages
{
    [Authorize]
    public class HomeModel : PageModel
    {
        [BindProperty]
        public int TournamentID { get; set; }
        [BindProperty]
        public List<Tournament>? TournamentListHome { get; set; }
        [BindProperty]
        public List<Tournament>? UpcomingtournamentOfCurrentUser { get; set; }
        [BindProperty]
        public List<Tournament>? CurrentTournamentOfCurrentUser { get; set; }
        public void OnGet()
        {
            ManagingTournament managingTournament = new ManagingTournament(new TournamentDAL());
            ManagingPerson managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            TournamentID = managingPerson.GetPlayerTournamentId(Convert.ToInt32(User?.FindFirst("UserId").Value));
            UpcomingtournamentOfCurrentUser = new List<Tournament>();
            CurrentTournamentOfCurrentUser = new List<Tournament>();
            TournamentListHome = managingTournament.GetAllTouanaments();
            if (TournamentID != 0)
            {
                foreach(Tournament tournament in TournamentListHome)
                {
                    if (tournament.TournamentId == TournamentID && tournament.StartingDate > DateTime.Now)
                    {
                        UpcomingtournamentOfCurrentUser.Add(tournament);
                    }
                    else if (tournament.TournamentId == TournamentID && tournament.StartingDate <= DateTime.Now)
                    {
                        CurrentTournamentOfCurrentUser.Add(tournament);
                    }
                }
            }
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return new RedirectToPageResult("Index");
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
