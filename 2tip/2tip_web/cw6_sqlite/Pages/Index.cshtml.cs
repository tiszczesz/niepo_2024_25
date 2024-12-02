using cw6_sqlite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw6_sqlite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CarsRepo _repo;
        public IndexModel(IConfiguration configuration)
        {
            //var conn = configuration.GetConnectionString("sqlite");
            _repo = new CarsRepo(configuration);
        }
        public void OnGet()
        {
        }
    }
}
