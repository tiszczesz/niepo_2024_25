using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw4_forms.Pages
{
    public class NwdModel : PageModel
    {
        [BindProperty]
        public Models.Nwd Nwd { get; set; }
        public void OnGet()
        {
        }
    }
}
