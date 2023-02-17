using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website_DuelSyns.Inc_Synthesis_2022.Pages.Shared
{
    public class LogOutModel : PageModel
    {
        public string LogOut { get; private set; }
        public LogOutModel()
        {
            LogOut = "Logout Page";
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return new RedirectToPageResult("Index");
        }
    }
}
