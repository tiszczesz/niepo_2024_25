using cw3_web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw3_web.Pages
{
    public class GamesModel : PageModel
    {
        public List<Game> Games { get; set; }
        public void OnGet()
        {
            Games = GamesRepo.GamesList();
        }
    }
}
