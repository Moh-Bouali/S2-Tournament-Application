using DataLayer;
using DesktopApp_Synthesis_Assignment_DuelSyns.Inc;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website_DuelSyns.Inc_Synthesis_2022.Pages
{
    public class DetailsPageModel : PageModel
    {
        ManagingMatch managingMatch;
        public ManagingPerson managingPerson;
        public string HomePlayerName { get; set; }
        public string AwayPlayerName { get; set; }
        public List<Match> Match { get; set; }
        public void OnGet(int id)
        {
            managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            managingMatch = new ManagingMatch(new MatchDAL());
            managingMatch.QueryMatches(id);
            Match = managingMatch.publicMatchesList;
        }
    }
}
