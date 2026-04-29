using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages.userPages
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public User u { get; set; }
        private readonly FakeDB DB;
        public DeleteModel(FakeDB db)
        {
            DB = db;
        }
        public void OnGet(int id)
        {
            u = DB.GetUserInfo(id);
        }
        public IActionResult OnPost()
        {
            DB.DeleteUser(u);
            return RedirectToPage("/index");
        }
    }
}
