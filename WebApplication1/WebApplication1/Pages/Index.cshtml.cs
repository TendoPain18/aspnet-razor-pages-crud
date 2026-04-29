using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FakeDB DB;

        public List<User> allUsers { get; set; }
        public IndexModel(ILogger<IndexModel> logger, FakeDB dB)
        {
            _logger = logger;
            DB = dB;
        }

        public void OnGet()
        {
            allUsers = DB.GetUsers();
        }
    }
}