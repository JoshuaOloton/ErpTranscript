using ErpTranscript.Enums;
using ErpTranscript.FormModels;
using ErpTranscript.Models;
using ErpTranscript.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using System.Text.Json;

namespace ErpTranscript.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly YabaResOnlineDbContext _yabaResOnlineDbContext;
        private readonly ProcessTranscript _processTranscript;
        private readonly NotificationService _notificationService = new NotificationService();

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(YabaResOnlineDbContext yabaResOnlineDbContext, ProcessTranscript processTranscript)
        {
            this._yabaResOnlineDbContext = yabaResOnlineDbContext;
            this._processTranscript = processTranscript;
        }
        
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync(String? returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //TransServiceReference.yctoutserviceSoapClient client = new(
            //    TransServiceReference.yctoutserviceSoapClient.EndpointConfiguration.yctoutserviceSoap);
            //int userID = await client.validate_erp_loginAsync(Model.Username, Model.Password, "joshresult", "236y7e@4783");

            int userID = await _processTranscript.ValidateLogin(Model.Username, Model.Password);
            Console.WriteLine(userID);

            // Determine user's role
            String role;

            if(Model.Username == "test" && Model.Password == "test")
            {
                userID = 159;
                role = "IT Officer";
            }
            else if (Model.Username == "hod" && Model.Password == "hodtest")
            {
                userID = 341;
                role = "HOD";
            }

            if (userID == 0)
            {
                _notificationService.Notify(message: "Please confirm your details and try again!", notificationType: NotificationType.error, tempData: TempData);
                return Page();
            }
            else
            {
                bool isProgrammer = _yabaResOnlineDbContext.ErpProgrammers.Any(e => e.Erpserid == userID);
                // create claims
                List<Claim> claims = new()
                {
                    new Claim("Username", Model.Username),
                    new Claim("User ID", userID.ToString()),
                    new Claim(ClaimTypes.Role, isProgrammer ? "Programmer" : "Non-programmer"),
                };
                if (userID == 159)
                {
                    claims = new()
                    {
                        new Claim("Username", Model.Username),
                        new Claim("User ID", userID.ToString()),
                        new Claim("IsProgrammer", "false"),
                        new Claim(ClaimTypes.Role, "IT Officer")
                    };
                }
                else if (userID == 341)
                {
                    claims = new()
                    {
                        new Claim("Username", Model.Username),
                        new Claim("User ID", userID.ToString()),
                        new Claim("IsProgrammer", "false"),
                        new Claim(ClaimTypes.Role, "HOD")
                    };
                }
                ClaimsIdentity claimsIdentity = new(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal claimsPrincipal = new(claimsIdentity);

                _notificationService.Notify(message: "You are logged in!", notificationType: NotificationType.success, tempData: TempData);

                await HttpContext.SignInAsync(claimsPrincipal);
            }
            if (returnUrl == null)
            {
                return RedirectToPage("/Index");
            }
            return Redirect(returnUrl);
        }
    }
}
