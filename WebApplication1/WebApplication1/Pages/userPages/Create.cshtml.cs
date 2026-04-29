using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages.userPages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public User u { get; set; }
        private readonly FakeDB DB;

        public CreateModel(FakeDB db)
        {
            DB = db;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            u.ID = DB.GetUsers().Max(a => a.ID) + 1;
            DB.AddUser(u);
            return RedirectToPage("/index");
        }
    }
}
