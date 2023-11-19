using ErpTranscript.Models.YabaResOnline;
using ErpTranscript.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ErpTranscript.Utilities;
using ErpTranscript.Models.Transcript;

namespace ErpTranscript.Pages
{
    public class HODModel : PageModel
    {
        private readonly NumberToWordsConverter _numberToWords;
        private readonly StudentDbContext _studentDbContext;
        private readonly TranscriptDbContext _transcriptDbContext;
        private readonly YabaResOnlineDbContext _yabaResOnlineDbContext;

        public IQueryable<VwTranscriptRequest?> PendingRequests { get; set; }
        public String SchoolName { get; set; }
        public String StaffName { get; set; }

        public HODModel(NumberToWordsConverter numberToWords,
            StudentDbContext studentDbContext,
            TranscriptDbContext transcriptDbContext,
            YabaResOnlineDbContext yabaResOnlineDbContext
            )
        {
            this._numberToWords = numberToWords;
            this._studentDbContext = studentDbContext;
            this._transcriptDbContext = transcriptDbContext;
            this._yabaResOnlineDbContext = yabaResOnlineDbContext;
        }

        public IActionResult? OnGet()
        {
            int transcriptID = 17;
            String? pageUrl = Url.Page("/Pending", pageHandler: "Confirm", values: new { transcriptID });

            String? userID = User.Claims?.FirstOrDefault(x => x.Type.Contains("User ID"))?.Value;

            //String? isProgrammer = User.Claims?.FirstOrDefault(x => x.Type.Contains("IsProgrammer")).Value;
            //this.IsProgrammer = bool.Parse(isProgrammer);

            this.PendingRequests = _transcriptDbContext.VwTranscriptRequests.Where(x => x.Cstatus == 4);

            if (this.PendingRequests.Any() && this.PendingRequests.Any(e => e.Flag == 1))
            {
                int len_errTranscripts = this.PendingRequests.Count(e => e.Flag == 1);
                if (len_errTranscripts == 1)
                {

                }
                ViewData["Error"] = len_errTranscripts == 1 ?
                    "A transcript has been flagged. Please click the ? icon to know more" :
                    $"{_numberToWords.ConvertToWords(len_errTranscripts)} transcripts have been flagged. Please click the ? icon to know more";
            }

            ErpDbContext erpDbContext = new();
            //var userId = authFilterContext.HttpContext.Request.Cookies.Where(c => c.Key == "userId").FirstOrDefault().Value;
            String userId = HttpContext.Request.Cookies.Where(c => c.Key == "userId").FirstOrDefault().Value;

            var previledge = (from record in erpDbContext.UserPreviledges
                              where record.Activityid == 3102
                              && record.Userid == System.Convert.ToInt32(userId)
                              select record);
            //if (previledge == null || !previledge.Any())
            //{
            //    return RedirectToPage("/Account/AccessDenied");
            //}

            var erpProgrammer = _yabaResOnlineDbContext.ErpProgrammers.Where(x => x.Erpserid == System.Convert.ToInt32(userId)).FirstOrDefault();

            if (erpProgrammer != null && this.PendingRequests != null)
            {
                int? SchoolID = erpProgrammer.Studentschoolid;

                //int? SchoolID = 4;

                // uncomment this line when you have the schoolID figured out
                //this.PendingRequests = this.PendingRequests.Where(x => x.Schoolid == SchoolID);

                //StudentDbContext studentDbContext = new();

                Models.Student.School? school = this._studentDbContext.Schools.Where(x => x.SchoolId == SchoolID).FirstOrDefault();

                //ErpDbContext erpDbContext = new();

                Models.Erp.User? user = erpDbContext.Users.Where(x => x.Id == System.Convert.ToInt32(userId)).FirstOrDefault();

                if (school != null)
                {
                    this.SchoolName = school.School1;

                    this.StaffName = user.Uname;
                }
            }

            return null;

        }
    }
}
