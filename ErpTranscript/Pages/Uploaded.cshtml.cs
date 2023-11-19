using ErpTranscript.Enums;
using ErpTranscript.FormModels;
using ErpTranscript.Models;
using ErpTranscript.Models.Transcript;
using ErpTranscript.Models.YabaResOnline;
using ErpTranscript.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using System.Diagnostics;

namespace ErpTranscript.Pages
{
    [Authorize]
    public class UploadedModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly NotificationService _notificationService = new NotificationService();
        private readonly TranscriptDbContext _transcriptDbContext;
        private readonly YabaResOnlineDbContext _yabaResOnlineDbContext;
        private readonly ProcessTranscript _processTranscript;

        public IQueryable<Models.Transcript.VwTranscriptRequest>? UploadedRequests { get; set; }
        public bool IsProgrammer { get; set; }
        public bool IsITOfficer { get; set; }

        [BindProperty]
        public Feedback Model { get; set; }

        public UploadedModel(
            IWebHostEnvironment environment,
            TranscriptDbContext transcriptDbContext,
            YabaResOnlineDbContext yabaResOnlineDbContext,
            ProcessTranscript processTranscript)
        {
            this._environment = environment;
            this._transcriptDbContext = transcriptDbContext;
            this._yabaResOnlineDbContext = yabaResOnlineDbContext;
            this._processTranscript = processTranscript;
        }

        public async Task<IActionResult?> OnGet()
        {
            String? userID = User.Claims?.FirstOrDefault(x => x.Type.Contains("User ID")).Value;

            if (User.IsInRole("Programmer"))   // is user is a programmer, view only transcript requests in programmer's school
            {
                List<ErpProgrammer> programmers = await _yabaResOnlineDbContext.ErpProgrammers.Where(e => e.Erpserid == System.Convert.ToInt32(userID)).ToListAsync();

                IEnumerable<int?> schoolIDs = programmers.Select(e => e.Studentschoolid);   // list of school IDs alone

                this.UploadedRequests = _transcriptDbContext.VwTranscriptRequests
                                                            .Where(x => schoolIDs.Contains(x.Schoolid) && x.Cstatus == 1);
            }
            else    // view all transcript requests if user is not a programmer
            {
                this.UploadedRequests = _transcriptDbContext.VwTranscriptRequests.Where(x => x.Cstatus == 1);
            }
            return null;
        }

        public async Task<IActionResult?> OnPostDeleteAsync(String remita, String returnPage)
        {
            Console.WriteLine("POST DELLLLEEEETTTTTTEEEE");
            Console.WriteLine($"REMITA: {remita}");
            var delwe = await _transcriptDbContext.TranscriptRequests.FirstOrDefaultAsync(e => e.RemitaRrr == remita);
            if (remita == null || delwe == null)
            {
                _notificationService.Notify(message: "Error deleting transcript!", notificationType: NotificationType.error, tempData: TempData);
                return returnPage switch
                {
                    "Pending" => RedirectToPage("/Pending"),
                    "Uploaded" => RedirectToPage("/Uploaded"),
                    _ => RedirectToPage("/Pending"),
                };
            }
            //string filePath = "path/to/file.txt";
            VwTranscriptRequest? studentTranscript = await _transcriptDbContext.VwTranscriptRequests.FirstOrDefaultAsync(e => e.RemitaRrr == remita);

            var file = Path.Combine(_environment.ContentRootPath, "wwwroot\\uploads", remita + "-STUDENT_COPY.pdf");
            var file1 = Path.Combine(_environment.ContentRootPath, "wwwroot\\uploads", remita + "-OFFICIAL_COPY.pdf");

            // Check if the file exists before attempting to delete it

            int status = await _processTranscript.Delete(delwe, file, file1);

            if (status == -1)   // Error deleting transcript
            {
                _notificationService.Notify(message: "An error occurred while deleting files and transcript.", notificationType: NotificationType.error, tempData: TempData);
            }
            else
            {
                _notificationService.Notify(message: $"Transcript for {studentTranscript.Surname} {studentTranscript.Firstname} deleted successfully!", notificationType: NotificationType.success, tempData: TempData);
            }

            return returnPage switch
            {
                "Pending" => RedirectToPage("/Pending"),
                "Uploaded" => RedirectToPage("/Uploaded"),
                _ => RedirectToPage("/Pending"),
            };
        }

        public async Task<IActionResult> OnGetResultStatement(String matNo)
        {
            Console.WriteLine("Do we get here?!?!");
            Console.WriteLine(matNo);
            String? finalResult = await _transcriptDbContext.TranscriptOrders
                .Where(e => e.Matricno == matNo)
                .Select(e => e.Finalresult)
                .FirstOrDefaultAsync();

            if (finalResult == null)
            {
                await Console.Out.WriteLineAsync("Finalresult is null");
                _notificationService.Notify("Result unavailable.", NotificationType.error, tempData: TempData);
                return RedirectToPage("/Uploaded");
            }

            return Redirect($"https://portal.yabatech.edu.ng/transcript/lastresult/{finalResult}");
        }

        public async Task<IActionResult?> OnPost(String remita)
        {
            // Get students matricno
            var student = _transcriptDbContext.TranscriptRequests.FirstOrDefault(x => x.RemitaRrr == remita);
            if (student == null)
            {
                _notificationService.Notify(message: "Record not found", notificationType: NotificationType.error, tempData: TempData);
                return Redirect("/Uploaded");
            }

            String filePath = Path.Combine(_environment.ContentRootPath, "wwwroot\\uploads", remita + "-" + "STUDENT_COPY.pdf");

            BinaryReader br = new BinaryReader(System.IO.File.OpenRead(filePath));
            byte[] fileBytes = br.ReadBytes((int)br.BaseStream.Length);

            // call api to handle approve request
            if (student.Studcopy == 1)
            {
                EmailServiceReference.yctoutserviceSoapClient emailClient = new(
                    EmailServiceReference.yctoutserviceSoapClient.EndpointConfiguration.yctoutserviceSoap);

                var result = await emailClient.sendmailAsync("olotonjoshua@gmail.com", student.Matricno, fileBytes);
                // FOR TESTING!!!!
                // CHANGE TO STUDENT'S EMAIL IN PRODUCTION

                var resultContent = result.sendmailResult;
            }

            var trans = await _transcriptDbContext.TranscriptRequests.FirstOrDefaultAsync(x => x.RemitaRrr == remita);

            if (trans != null)
            {
                trans.Cstatus = 2; // 2 - uploaded and approval
                trans.Fstatus = 1;
                trans.ApproveDate = DateTime.Now;
                _transcriptDbContext.SaveChanges();
                _notificationService.Notify("Transcript Approved!", NotificationType.success, tempData: TempData);
            }

            return Redirect("/Uploaded");
        }

        public async Task<IActionResult> OnPostFlag(String rrr)
        {
            Console.WriteLine("Feedback Page handler");
            Console.WriteLine(rrr);
            // Get students matricno

            if (!ModelState.IsValid)
            {
                _notificationService.Notify(message: "Please enter a message to submit your feedback.", notificationType: NotificationType.error, tempData: TempData);
                return RedirectToPage("/Uploaded");
            }
            var transcript = _transcriptDbContext.TranscriptRequests.FirstOrDefault(x => x.RemitaRrr == rrr);
            String? username = User.Claims?.FirstOrDefault(x => x.Type.Contains("Username")).Value;
            if (transcript is null || username is null)
            {
                _notificationService.Notify(message: "Record not found", notificationType: NotificationType.error, tempData: TempData);
                await HttpContext.SignOutAsync();
                return RedirectToPage("/Account/Login");
            }

            // Set transcript flag
            transcript.Flag = 1;
            transcript.Flagby = username;
            transcript.Flagmsg = Model.FeedbackMessage;

            // reset transcript
            transcript.Cstatus = 0;
            transcript.Fstatus = 0;

            // delete transcript location
            var transcriptToDelete = await _transcriptDbContext.TranscriptUploads.FirstOrDefaultAsync(e => e.Matricno == transcript.Matricno);
            if (transcriptToDelete is not null)
            {
                _transcriptDbContext.TranscriptUploads.Remove(transcriptToDelete);
            }
            await _transcriptDbContext.SaveChangesAsync();
            _notificationService.Notify(message: "Your feedback has been submitted.", notificationType: NotificationType.info, tempData: TempData);

            return RedirectToPage("/Uploaded");
        }
    }
}
