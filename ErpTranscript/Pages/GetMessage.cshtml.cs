using ErpTranscript.Enums;
using ErpTranscript.Models;
using ErpTranscript.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Pages
{
    public class GetMessageModel : PageModel
    {
        private readonly TranscriptDbContext _transcriptDbContext;
        private readonly NotificationService _notificationService = new NotificationService();

        public GetMessageModel(TranscriptDbContext transcriptDbContext)
        {
            _transcriptDbContext = transcriptDbContext;
        }

        public async Task<IActionResult> OnGet(String rrr)
        {
            Console.WriteLine($"Remita ==> {rrr}");
            var remitaFlag = _transcriptDbContext.TranscriptRequests.Where(e => e.RemitaRrr == rrr);
            String? flagBy = await remitaFlag.Select(e => e.Flagby).FirstOrDefaultAsync();
            String? flagMsg = await remitaFlag.Select(e => e.Flagmsg).FirstOrDefaultAsync();
            Console.WriteLine(flagBy);
            Console.WriteLine(flagMsg);
            //String flagBy = "Flagged by Josh";
            //String flagMsg = "Do in laughter securing smallest sensible no mr hastened. As perhaps proceed in in brandon of limited unknown greatly. Distrusts fulfilled happiness unwilling as explained of difficult. No landlord of peculiar ladyship attended if contempt ecstatic";

            //if (flagMsg is null)
            //{
            //    _notificationService.Notify("Error fetching Feeedback.", NotificationType.error, tempData: TempData);
            //    return RedirectToPage("/Pending");
            //}


            var flagData = new { FlagBy = flagBy, FlagMsg = flagMsg };

            return new JsonResult(flagData);
        }
    }
}
