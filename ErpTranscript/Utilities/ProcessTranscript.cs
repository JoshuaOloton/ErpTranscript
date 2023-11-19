using ErpTranscript.Models;
using ErpTranscript.Models.Transcript;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;

namespace ErpTranscript.Utilities
{
    public class ProcessTranscript
    {
        private readonly TranscriptDbContext _transcriptDbContext;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProcessTranscript(TranscriptDbContext transcriptDbContext, IHttpClientFactory httpClientFactory)
        {
            _transcriptDbContext = transcriptDbContext;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<int> ValidateLogin(String erpuser, String erpPassword)
        {
            string xmlBody = @$"<?xml version=""1.0"" encoding=""utf-8""?>
<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
  <soap:Body>
    <validate_erp_login xmlns=""https://portal.yabatech.edu.ng/"">
      <erpuser>{erpuser}</erpuser>
      <erp_password>{erpPassword}</erp_password>
      <userid>joshresult</userid>
      <usertoken>236y7e@4783</usertoken>
    </validate_erp_login>
  </soap:Body>
</soap:Envelope>";

            String url = "https://portal.yabatech.edu.ng/paymentservice/yctoutservice.asmx?op=validate_erp_login";

            // make soap API call, parse response   
            String? xmlResponse = await PostSOAPRequestAsync(url, xmlBody);

            var soapResponseXml = XDocument.Parse(xmlResponse);
            String? responseValue = soapResponseXml.Descendants().FirstOrDefault(e => e.Name.LocalName == "validate_erp_loginResult")?.Value;

            int result = Convert.ToInt32(responseValue);
            return result;
        }

        private async Task<String> PostSOAPRequestAsync(String url, String text)
        {
            var httpClient = _httpClientFactory.CreateClient("AppHttpClient");

            using HttpContent content = new StringContent(text, Encoding.UTF8, "text/xml");
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);

            request.Content = content;
            using (HttpResponseMessage response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
            {
                //response.EnsureSuccessStatusCode(); // throws an Exception if 404, 500, etc.
                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<int> Delete(TranscriptRequest transcript, String? studentFile, String? officialFile)
        {
            try
            {
                if (System.IO.File.Exists(studentFile))
                {
                    System.IO.File.Delete(studentFile);
                }
                if (System.IO.File.Exists(officialFile))
                {
                    System.IO.File.Delete(officialFile);
                }

                transcript.Cstatus = 0;
                transcript.Fstatus = 0;
                Console.WriteLine("Alread cleared?");
                // Reset flag status
                transcript.Flag = null;
                transcript.Flagby = null;
                transcript.Flagmsg = null;

                // delete transcript location
                var transcriptToDelete = await _transcriptDbContext.TranscriptUploads.FirstOrDefaultAsync(e => e.Matricno == transcript.Matricno);
                if (transcriptToDelete is not null)
                {
                    _transcriptDbContext.TranscriptUploads.Remove(transcriptToDelete);
                }
                await _transcriptDbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                // Handle any exceptions that may occur during the file deletion or database operations
                Console.WriteLine($"Error occurred: {ex.Message}");
                return -1;
            }

            return 1;
        }
    }
}
