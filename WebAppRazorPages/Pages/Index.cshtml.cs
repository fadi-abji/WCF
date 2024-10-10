using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ViewData["Add"] = await client.AddAsync(10.9, 20.0);
            ViewData["Sub"] = await client.SubAsync(10, 20);
            ViewData["Multipli"] = await client.MultipliAsync(10, 20);
            ViewData["Divide"] = await client.DivideAsync(10, 20);
        }
    }
}
