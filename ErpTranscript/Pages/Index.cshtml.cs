using ErpTranscript.Models;
using ErpTranscript.Models.Transcript;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly TranscriptDbContext _transcriptDbContext;

        public List<TranscriptRequest> PendingRequests { get; set; }
        public List<TranscriptRequest> UploadedRequests { get; set; }

        public IndexModel(ILogger<IndexModel> logger, TranscriptDbContext transcriptDbContext)
        {
            _logger = logger;
            _transcriptDbContext = transcriptDbContext;
        }

        public async Task<IActionResult?> OnGetAsync()
        {
            this.PendingRequests = await _transcriptDbContext.TranscriptRequests.Where(x => x.Cstatus == 0).ToListAsync();
            this.UploadedRequests = await _transcriptDbContext.TranscriptRequests.Where(x => x.Cstatus != 0).ToListAsync();

            return null;
        }
    }
}