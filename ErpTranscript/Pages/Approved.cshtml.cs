using ErpTranscript.Models;
using ErpTranscript.Models.Transcript;
using ErpTranscript.Models.YabaResOnline;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;

namespace ErpTranscript.Pages
{
    public class ApprovedModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly TranscriptDbContext _transcriptDbContext;
        private readonly YabaResOnlineDbContext _yabaResOnlineDbContext;

        public List<VwTranscriptRequest>? ApprovedRequests { get; set; }
        public bool IsProgrammer { get; set; }
        public bool IsITOfficer { get; set; }

        public ApprovedModel(IWebHostEnvironment environment, TranscriptDbContext transcriptDbContext,
            YabaResOnlineDbContext yabaResOnlineDbContext)
        {
            this._environment = environment;
            this._transcriptDbContext = transcriptDbContext;
            this._yabaResOnlineDbContext = yabaResOnlineDbContext;
        }

        public async Task<IActionResult?> OnGet()
        {
            String? userID = User.Claims?.FirstOrDefault(x => x.Type.Contains("User ID")).Value;

            if (User.IsInRole("Programmer"))  // is user is a programmer, view only transcript requests in programmer's school
            {
                List<ErpProgrammer> programmers = await _yabaResOnlineDbContext.ErpProgrammers.Where(e => e.Erpserid == System.Convert.ToInt32(userID)).ToListAsync();

                IEnumerable<int?> schoolIDs = programmers.Select(e => e.Studentschoolid);   // list of school IDs alone

                this.ApprovedRequests = await _transcriptDbContext.VwTranscriptRequests
                                                            .Where(x => schoolIDs.Contains(x.Schoolid) && x.Cstatus == 2).ToListAsync();
                //this.ApprovedRequests = _transcriptDbContext.VwTranscriptRequests.Where(x => x.Cstatus == 1);
            }
            else    // view all transcript requests if user is not a programmer
            {
                this.ApprovedRequests = await _transcriptDbContext.VwTranscriptRequests.Where(x => x.Cstatus == 2).ToListAsync();
            }

            //this.ApprovedRequests = _transcriptDbContext.VwTranscriptRequests.Where(x => x.Cstatus == 2);
            using (var erpContext = new ErpDbContext())
            {
                //var userId = authFilterContext.HttpContext.Request.Cookies.Where(c => c.Key == "userId").FirstOrDefault().Value;
                String userId = HttpContext.Request.Cookies.Where(c => c.Key == "userId").FirstOrDefault().Value;

                var previledge = (from record in erpContext.UserPreviledges
                                  where record.Activityid == 10
                                  && record.Userid == System.Convert.ToInt32(userId)
                                  select record);
                //if (previledge == null || !previledge.Any())
                //{
                //    return Redirect("/Account/AccessDenied");
                //}
            }
            return null;
        }

        public async Task<IActionResult> OnGetCloseRequest(String remita)
        {
            TranscriptRequest? request = await _transcriptDbContext.TranscriptRequests.FirstOrDefaultAsync(e => e.RemitaRrr == remita);

            if (request is not null)
            {
                request.Closereq = 1;
                await _transcriptDbContext.SaveChangesAsync();
            }

            return RedirectToPage("/Approved");
        }

        public void OnPost()
        {

        }

        public async Task<String?> GetDestination(String remitaRRR)
        {
            var location = (await _transcriptDbContext.TranscriptRequests.FirstOrDefaultAsync(e => e.RemitaRrr == remitaRRR))?.Tdestination;
            return location;
        }
    }
}
