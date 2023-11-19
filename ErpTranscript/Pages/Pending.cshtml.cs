using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ErpTranscript.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ErpTranscript.Enums;
using Microsoft.AspNetCore.Authorization;
using ErpTranscript.Models.YabaResOnline;
using ErpTranscript.Models.Transcript;
using SelectPdf;
using ErpTranscript.Utilities;
using System.IO;
using System.Linq;

namespace ErpTranscript.Pages
{
    [Authorize]
    //[Authorize(Policy = "RequiredPermissions")]
    public class PendingModel : PageModel
    {
        private readonly NotificationService _notificationService = new NotificationService();
        private readonly IWebHostEnvironment _environment;
        private readonly NumberToWordsConverter _numberToWords;
        private readonly StudentDbContext _studentDbContext;
        private readonly TranscriptDbContext _transcriptDbContext;
        private readonly YabaResOnlineDbContext _yabaResOnlineDbContext;
        private readonly ProcessTranscript _processTranscript;
        private String[] permittedExtensions = {".pdf"};

        public String SchoolName { get; set; }
        public String StaffName { get; set; }
        public IQueryable<Models.Transcript.VwTranscriptRequest?> PendingRequests { get; set; }

        [Required(ErrorMessage = "Please select a file.")]
        [BindProperty]
        public IFormFile StudentUpload { get; set; }
        [BindProperty]
        public IFormFile OfficialUpload { get; set; }

        public bool IsProgrammer { get; set; }

        public PendingModel(
            IWebHostEnvironment env, 
            NumberToWordsConverter numberToWords,
            StudentDbContext studentDbContext, 
            TranscriptDbContext transcriptDbContext, 
            YabaResOnlineDbContext yabaResOnlineDbContext,
            ProcessTranscript processTranscript)
        {
            this._environment = env;
            this._numberToWords = numberToWords;
            this._studentDbContext = studentDbContext;
            this._transcriptDbContext = transcriptDbContext;
            this._yabaResOnlineDbContext = yabaResOnlineDbContext;
            this._processTranscript = processTranscript;
        }

        public async Task<IActionResult?> OnGetAsync()
        {
            int transcriptID = 17;
            String? pageUrl = Url.Page("/Pending", pageHandler: "Confirm", values: new { transcriptID });

            String? userID = User.Claims?.FirstOrDefault(x => x.Type.Contains("User ID"))?.Value;

            //String? isProgrammer = User.Claims?.FirstOrDefault(x => x.Type.Contains("IsProgrammer")).Value;
            //this.IsProgrammer = bool.Parse(isProgrammer);

            if (User.IsInRole("Programmer"))   // is user is a programmer, view only transcript requests in programmer's school
            {
                List<ErpProgrammer> programmers = await _yabaResOnlineDbContext.ErpProgrammers.Where(e => e.Erpserid == System.Convert.ToInt32(userID)).ToListAsync();

                IEnumerable<int?> schoolIDs = programmers.Select(e => e.Studentschoolid);   // list of school IDs alone

                this.PendingRequests = _transcriptDbContext.VwTranscriptRequests
                                                            .Where(x => schoolIDs.Contains(x.Schoolid) && x.Cstatus == 0);
            }
            else    // view all transcript requests if user is not a programmer
            {
                this.PendingRequests = _transcriptDbContext.VwTranscriptRequests
                                                            .Where(x => x.Cstatus == 0);
            }

            if (this.PendingRequests.Any() && this.PendingRequests.Any(e => e.Flag == 1))
            {
                int len_errTranscripts = this.PendingRequests.Count(e => e.Flag == 1);
                if (len_errTranscripts == 1)
                {

                }
                ViewData["Error"] = len_errTranscripts == 1 ?
                    "A transcript has been flagged. Please click the ⓘ icon to know more" :
                    $"{_numberToWords.ConvertToWords(len_errTranscripts)} transcripts have been flagged. Please click the ⓘ icon to know more";
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

        public IActionResult? OnGetGeneratePDF()
        {
            Console.WriteLine("IS IT WORKING NOW???");
            //var renderer = new HtmlToPdf();
            //var pdf = await renderer.RenderUrlAsPdfAsync("https://localhost:7040/Transcript?matricNo=F%2FND%2F20%2F3270001&type=STUDENT&handler=GeneratePDF");
            //pdf.SaveAs("mypdf.pdf");

            //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://apple.com");
            ////Create response-object
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            ////Take response stream
            //StreamReader sr = new StreamReader(response.GetResponseStream());
            ////Read response stream (html code)
            //string htmlString = sr.ReadToEnd();
            ////Close streamreader and response
            //sr.Close();
            //response.Close();

            //PdfSharp.Pdf.PdfDocument pdfDocument = PdfGenerator.GeneratePdf(htmlString, PageSize.A4);
            //pdfDocument.Save("examplee.pdf");

            HtmlToPdf converter = new HtmlToPdf();
            converter.Options.CssMediaType = HtmlToPdfCssMediaType.Print;
            //converter.Options.CustomCSS = 

            SelectPdf.PdfDocument doc = converter.ConvertUrl("https://localhost:7040/Transcript?matricNo=F%2FND%2F20%2F3270001&type=STUDENT");

            doc.Save("examplleee.pdf");
            doc.Close();

            return null;
        }

        public async Task<IActionResult> OnGetResultStatement(String matNo)
        {
            Console.WriteLine("Don't we get here?!?!");
            Console.WriteLine(matNo);
            String? finalResult = await _transcriptDbContext.TranscriptOrders
                .Where(e => e.Matricno == matNo && e.Finalresult != null)
                .Select(e => e.Finalresult)
                .FirstOrDefaultAsync();

            if(finalResult == null)
            {
                await Console.Out.WriteLineAsync("Finalresult is null");
                _notificationService.Notify("Result unavailable.", NotificationType.error, tempData: TempData);
                return RedirectToPage("/Pending");
            }

            return Redirect($"https://portal.yabatech.edu.ng/transcript/lastresult/{finalResult}");
        }

        //[ValidateAntiForgeryToken]
        public async Task<IActionResult?> OnPostAsync(String remita)
        {
            Console.WriteLine("Are you null");
            Console.WriteLine(remita);
            Console.WriteLine("Let's see");
            if (StudentUpload == null || OfficialUpload == null)
           {
                _notificationService.Notify("Select both files to upload!", NotificationType.error, tempData: TempData);
                return Redirect("/Pending");
           }

            VwTranscriptRequest? studentTranscript = await _transcriptDbContext.VwTranscriptRequests.FirstOrDefaultAsync(e => e.RemitaRrr == remita);

            if (remita == null || studentTranscript == null)
            {
                _notificationService.Notify("Error uploading Transcript! Please refresh your page and try again!", NotificationType.error, tempData: TempData);
                return Redirect("/Pending");
            }

            String? firstname = studentTranscript.Firstname;
            String? surname = studentTranscript.Surname;

            //String filePath;

            await UploadFile(remita, StudentUpload, "STUDENT_COPY");
            await UploadFile(remita, OfficialUpload, "OFFICIAL_COPY");

            _notificationService.Notify($"Transcripts uploaded for {surname} {firstname}!", NotificationType.success, tempData: TempData);

            var trans = _transcriptDbContext.TranscriptRequests.SingleOrDefault(x => x.RemitaRrr == remita);

            //var context = new EBPortalDbContext();
            //var trans = context.TranscriptRequests.SingleOrDefault(x => x.RemitaRrr == remita);
            if (trans != null)
            {
                trans.Cstatus = 3; // new update: 3 - uploaded to hod
                // reset flag status
                trans.Flag = null;
                trans.Flagby = null;
                trans.Flagmsg = null;

                // ADD file location to TranscriptsUpload table
                TranscriptUpload upload = new()
                {
                    Matricno = studentTranscript.Matricno,
                    Loc2 = $"uploads/{remita}-OFFICIAL_COPY.pdf",
                    Loc = $"uploads/{remita}-STUDENT_COPY.pdf"
                };

                _transcriptDbContext.TranscriptUploads.Add(upload);
                _transcriptDbContext.SaveChanges();

                // Add activity to erplog
                //using (var erpContext = new ErpDbContext())
                //{
                //    var log = new Models.Erp.ErpLog
                //    {
                //        UserId = "mmm",
                //        LogDate = DateTime.Now,
                //        Action = "Uploaded transcript",
                //        UserIp = "ip",
                //        Studnum = trans.Matricno
                //    };

                //    erpContext.ErpLogs.Add(log);
                //    erpContext.SaveChanges();
                //}
            }

            return Redirect("/Pending");
        }

        public async Task<IActionResult?> UploadFile(String remita, IFormFile upload, String transcriptName)
        {
            var ext = Path.GetExtension(upload.FileName).ToLowerInvariant();
            if (String.IsNullOrEmpty(ext) || !permittedExtensions.Contains(ext))
            {
                _notificationService.Notify("Selected file must be a pdf document!", NotificationType.error, tempData: TempData);
                return RedirectToPage("/Pending");
            }

            var file = Path.Combine(_environment.ContentRootPath, "wwwroot\\uploads", remita + "-" + transcriptName + ext);
            using (var filestream = new FileStream(file, FileMode.Create))
            {
                await upload.CopyToAsync(filestream);
            }

            // Update db with location of Offficial transcript
            if (transcriptName == "OFFICIAL_COPY")
            {
                var location = new Models.Transcript.TranscriptUpload
                {
                    //Matricno = 
                };


            }

            return null;
        }

        public async Task<IActionResult?> OnPostDeleteAsync(String remita)
        {
            Console.WriteLine("POST DELLLLEEEETTTTTTEEEE");
            Console.WriteLine($"REMITA: {remita}");
            var delwe = await _transcriptDbContext.TranscriptRequests.FirstOrDefaultAsync(e => e.RemitaRrr == remita);
            if (remita == null || delwe == null)
            {
                _notificationService.Notify(message: "Error deleting transcript!", notificationType: NotificationType.error, tempData: TempData);
                return RedirectToPage("/Pending");
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

            return RedirectToPage("/Pending");
        }

        public async Task<IActionResult> OnGetConfirmAsync(int transcriptID)
        {
            // Update the document in the database using EF Core
            // ...

            TranscriptRequest? transcript = await _transcriptDbContext.TranscriptRequests.FirstOrDefaultAsync(e => e.Id == transcriptID);
            transcript.Cstatus = 1;
            await _transcriptDbContext.SaveChangesAsync();


            return Page(); // Return a 200 OK response
        }

        public IActionResult OnGetViewTranscript(String matricNo, String copy)
        {
            //SaveToPdf();

            return RedirectToPage("/Transcript", new { matricNo = matricNo, copy = copy});
        }

        public async Task<String?> GetMessage(String rrr)
        {
            String? feedbackMsg = await _transcriptDbContext.TranscriptRequests.Where(e => e.RemitaRrr == rrr).Select(e => e.Flagmsg).FirstOrDefaultAsync();

            return feedbackMsg;
        }

        public void SaveToPdf()
        {
            // SAVE PAGE AS PDF

            // Get file html content
            String url = "https://localhost:7040/Transcript?matricNo=F%2FND%2F20%2F3270001&copy=STUDENT-COPY";
            String cssUrl = "https://localhost:7040/css/transcript.css";

            HttpClient hclient = new HttpClient();
            //hclient.BaseAddress = new Uri(url);
            HttpResponseMessage response = hclient.GetAsync(url).Result;

            HttpContent content = response.Content;
            String htmlContent = content.ReadAsStringAsync().Result;



            HttpResponseMessage response2 = hclient.GetAsync(cssUrl).Result;

            HttpContent content2 = response2.Content;
            String cssContent = content2.ReadAsStringAsync().Result;


            //String outputPath = Path.Combine(_environment.ContentRootPath, "wwwroot\\uploads", "testt.pdf");

            //using (FileStream fs = new FileStream(outputPath, FileMode.Create))
            //{
            //    Document document = new Document(iTextSharp.text.PageSize.A4, 45, 5, 5, 5);
            //    PdfWriter writer = PdfWriter.GetInstance(document, fs);

            //    document.Open();

            //    HTMLWorker htmlWorker = new HTMLWorker(document);

            //    var cssResolver = new StyleAttrCSSResolver();

            //    // Load external CSS file
            //    var cssFilePath = "https://localhost:7040/css/transcriptprint.css";
            //    using (var cssFileStream = new FileStream(cssFilePath, FileMode.Open))
            //    {
            //        var cssFile = XMLWorkerHelper.GetCSS(cssFileStream);
            //        cssResolver.AddCss(cssFile);
            //    }

            //    // Create an XML worker with the CSS resolver
            //    var xmlWorker = new XMLWorker(htmlWorker, new List<ICSSResolver> { cssResolver });

            //    // Parse the HTML content and add it to the PDF document
            //    using (StringReader stringReader = new StringReader(htmlContent))
            //    {
            //        XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, stringReader);
            //    }
            //    document.Close();
            //}

            // Create a new PDF document
            //Document document = new Document();

            //// Create a PDF writer that writes the document to the specified file path
            //PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Path.Combine(_environment.ContentRootPath, "wwwroot\\uploads", "testt.pdf"), FileMode.Create));

            //// Open the PDF document
            //document.Open();

            //using (Stream cssStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(cssContent)))
            //{
            //    // Create a CSS resolver and CSS XML parser
            //    ICSSResolver cssResolver = XMLWorkerHelper.GetInstance().GetDefaultCssResolver(false);
            //    var cssFile = XMLWorkerHelper.GetCSS(cssStream);
            //    cssResolver.AddCss(cssFile);

            //    // Create an XML worker and HTML parser with the CSS resolver
            //    XMLWorkerFontProvider fontProvider = new XMLWorkerFontProvider();
            //    CssAppliers cssAppliers = new CssAppliersImpl(fontProvider);
            //    HtmlPipelineContext htmlContext = new HtmlPipelineContext(cssAppliers);
            //    htmlContext.SetTagFactory(Tags.GetHtmlTagProcessorFactory());
            //    htmlContext.AutoBookmark(true);

            //    // Create a pipeline for HTML and CSS processing
            //    PdfWriterPipeline pipeline = new PdfWriterPipeline(document, writer);
            //    HtmlPipeline htmlPipeline = new HtmlPipeline(htmlContext, pipeline);
            //    CssResolverPipeline cssPipeline = new CssResolverPipeline(cssResolver, htmlPipeline);

            //    // Create an XML worker with the CSS pipeline
            //    XMLWorker worker = new XMLWorker(cssPipeline, true);
            //    XMLParser xmlParser = new XMLParser(worker);

            //    // Convert HTML content to a stream
            //    using (Stream htmlStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(htmlContent)))
            //    {
            //        // Parse the HTML stream and add it to the PDF document
            //        xmlParser.Parse(htmlStream);
            //    }
            //}

            //// Close the PDF document
            //document.Close();
        }
    }
}
