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
            ViewData["message"] = "Przed zatwierdzeniem formularza wprowadź dane";
        }
        public void OnPost()
        {
            ViewData["method"] = "POST";
            if (ModelState.IsValid)
            {
                ViewData["message"] = "Dane zostały zapisane";
            }
            else
            {
                ViewData["message"] = "Dane nie zostały zapisane";
            }
        }
    }
}
