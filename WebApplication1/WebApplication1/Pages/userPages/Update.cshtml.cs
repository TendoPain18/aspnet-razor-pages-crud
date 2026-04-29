using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages.userPages
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public User u { get; set; }

        private readonly FakeDB DB;
        public UpdateModel(FakeDB dB)
        {
            DB = dB;
        }

        public void OnGet(int id)
        {
            u = DB.GetUserInfo(id);
        }

        public IActionResult OnPost()
        {
            DB.UpdateUserInfo(u);
            return RedirectToPage("/index");
        }
    }
}
