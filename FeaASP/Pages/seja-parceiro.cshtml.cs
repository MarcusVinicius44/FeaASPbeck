using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FEAasp.Pages
{
    public class SejaModel : PageModel
    {
        private readonly ILogger<SejaModel> _logger;

        public SejaModel(ILogger<SejaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}