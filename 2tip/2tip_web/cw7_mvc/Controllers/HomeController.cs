using Microsoft.AspNetCore.Mvc;

namespace cw7_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            string message = "Hello, World!";
            return View("Index",message);
        }
        public ActionResult List()
        {
            List<string> colors = new List<string>
            {
                "Red",
                "Green",
                "Blue",
                "Yellow",
                "Purple"
            };
            return View(colors);
        }

    }
}
