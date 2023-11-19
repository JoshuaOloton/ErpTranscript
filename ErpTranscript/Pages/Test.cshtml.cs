using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ErpTranscript.Pages
{
    public class TestModel : PageModel
    {
        public void OnGet()
        {
        }

        public async Task OnPost()
        {
            ServiceReference2.yctoutserviceSoapClient client = new(
                ServiceReference2.yctoutserviceSoapClient.EndpointConfiguration.yctoutserviceSoap);

            int userID = await client.validate_erp_loginAsync("evangel", "1234567", "joshresult", "236y7e@4783");

            Console.Out.WriteLine("USER ID");
            Console.Out.WriteLine(userID);
        }
    }
}
