using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HangfireServer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogTrace(" -> Get Method is called");
            _logger.LogDebug("-> Get Method is called");
            _logger.LogInformation(" -> Get Method is called");
            _logger.LogWarning("-> Get Method is called");
        }
    }
}