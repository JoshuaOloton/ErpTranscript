using ErpTranscript.Enums;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace ErpTranscript.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await HttpContext.SignOutAsync();
            Notify(message: "You are logged out!", notificationType: NotificationType.error);
 
            return RedirectToPage("/Account/Login");
        }

        public void Notify(String message, NotificationType notificationType = NotificationType.success)
        {
            var msg = new
            {
                message = message,
                type = notificationType.ToString()
            };
            TempData["notification"] = JsonSerializer.Serialize(msg);
        }
    }
}
