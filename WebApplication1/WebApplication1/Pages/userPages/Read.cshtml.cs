using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages.userPages
{
    public class ReadModel : PageModel
    {
        public User u { get; set; }

        private readonly FakeDB DB;

        public ReadModel(FakeDB dB)
        {
            DB= dB;
        }
        public void OnGet(int id)
        {
            u = DB.GetUserInfo(id);
        }
    }
}
