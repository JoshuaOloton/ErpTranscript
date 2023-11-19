using ErpTranscript.Enums;
using ErpTranscript.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Server.Kestrel;
using SelectPdf;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ErpTranscript.Pages
{
    //[Authorize]
    public class TranscriptModel : PageModel
    {
        private readonly NotificationService _notificationService = new NotificationService();
        private readonly IWebHostEnvironment _environment;

        public TranscriptModel(IWebHostEnvironment environment)
        {
            this._environment = environment;
        }

        public String TranscriptType { get; set; }
        public XElement? HeadingData { get; set; }
        public IEnumerable<XElement>? SubHeadingData { get; set; }
        public IEnumerable<XElement>? BodyData { get; set; }
        public XElement? SummaryData { get; set; }
        public String TranscriptKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnGetAsync()
        {
            this.TranscriptType = Request.Query["copy"];
            String matricNo = Request.Query["matricNo"];
            matricNo = matricNo.Replace("%2F", "/");
            ServiceReference1.WebServiceSoapClient client = new ServiceReference1.WebServiceSoapClient(ServiceReference1.WebServiceSoapClient.EndpointConfiguration.WebServiceSoap);

            try
            {
                //int confirm = await client.confirm_if_on_eresultAsync(matricNo, "joshresult", "236y7e@4783");

                //if (confirm != 1)
                //{
                //    _notificationService.Notify(message: "Transcript Result not found!", notificationType: NotificationType.error, tempData: TempData);
                //    return RedirectToPage("/Pending");
                //}

                // GET HEADING DATA
                var heading = await client.ret_transcript_headrAsync(matricNo, "joshresult", "236y7e@4783");

                var serializer = new XmlSerializer(heading.GetType());
                var ms = new MemoryStream();
                serializer.Serialize(ms, heading);

                String xml = Encoding.UTF8.GetString(ms.ToArray());

                XDocument respXml = XDocument.Parse(xml);

                this.HeadingData = respXml.Descendants("Transcript_head").FirstOrDefault();


                // GET SUBHEADING DATA
                var subHeading = await client.ret_er5_fortranscript_subheadAsync(matricNo, "joshresult", "236y7e@4783");

                serializer = new XmlSerializer(subHeading.GetType());
                ms = new MemoryStream();
                serializer.Serialize(ms, subHeading);

                xml = Encoding.UTF8.GetString(ms.ToArray());

                respXml = XDocument.Parse(xml);

                this.SubHeadingData = respXml.Descendants("Table").Select(e => e);


                // GET BODY DATA
                var subBody = await client.ret_resultbody_for_transcriptAsync(matricNo, "joshresult", "236y7e@4783");

                serializer = new XmlSerializer(subBody.GetType());
                ms = new MemoryStream();
                serializer.Serialize(ms, subBody);

                xml = Encoding.UTF8.GetString(ms.ToArray());

                respXml = XDocument.Parse(xml);

                this.BodyData = respXml.Descendants("Table").Select(e => e);

                // GET TRANSCRIPT SUMMARY
                var summary = await client.ret_result_summary_for_transcriptAsync(matricNo, "joshresult", "236y7e@4783");

                serializer = new XmlSerializer(summary.GetType());
                ms = new MemoryStream();
                serializer.Serialize(ms, summary);

                xml = Encoding.UTF8.GetString(ms.ToArray());

                respXml = XDocument.Parse(xml);

                this.SummaryData = respXml.Descendants("Table").FirstOrDefault();

                // GET TRANSCRIPT KEY
                this.TranscriptKey = await client.get_transcriptid_formatricnoAsync(matricNo, "joshresult", "236y7e@4783");
            }
            catch (Exception e)
            {
                Console.WriteLine("MESSAGE");
                Console.WriteLine(e.Message);
                _notificationService.Notify("Error fetching transcript details!", NotificationType.error, tempData: TempData);
                return RedirectToPage("/Pending");
            }

            return null;
        }

        public FileResult OnPostExport(string GridHtml)
        {
            return null;
        }
    }
}
