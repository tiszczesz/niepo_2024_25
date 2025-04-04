
using cw3_web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw3_web.Pages
{
    public class IndexModel : PageModel
    {
        public List<Person>? Persons { get; set; }
        public void OnGet()
        {
            Persons = PersonsRepo.GetPersons();
        }
    }
}
