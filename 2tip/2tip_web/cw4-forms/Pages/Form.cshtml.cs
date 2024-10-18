using cw4_forms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw4_forms.Pages
{
    public class FormModel : PageModel
    {
        [BindProperty]
        public Person MyPerson { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            var person = MyPerson;
        }
    }
}
