using DataLayer;
using DesktopApp_Synthesis_Assignment_DuelSyns.Inc;
using DTO;
using LogicLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Website_DuelSyns.Inc_Synthesis_2022.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public WebsiteUser person { get; set; } 

        public async Task<IActionResult> OnPost()
        {
            string password = person.Password;
            ManagingPerson managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            string salt = managingPerson.GetSalt(person.ID);
            password = Static.HashPassword(password, salt, 10101, 70);
            ModelState.Clear();
            if (ModelState.IsValid)
            {
                if (managingPerson.CheckLoginForPlayer(person.ID, password))
                {
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim("UserId", person.ID.ToString()));
                    claims.Add(new Claim(ClaimTypes.Name, managingPerson.GetName(Convert.ToInt32(person.ID))));
                    var Identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(new ClaimsPrincipal(Identity));
                    return new RedirectToPageResult("Home");
                }
            }
            return Page();
        }
    }
}