using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw4_forms.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            var request = Request;
            ViewData["method"] = request.Method;
            ViewData["firstname"] = request.Query["firstname"];
            ViewData["lastname"] = request.Query["lastname"];
            ViewData["age"] = request.Query["age"];
        }
        public void OnPost()
        {
            var request = Request;
            ViewData["method"] = request.Method;
            ViewData["firstname"] = request.Form["firstname"];
            ViewData["lastname"] = request.Form["lastname"];
            ViewData["age"] = request.Form["age"];
        }
    }
}
