using Microsoft.AspNetCore.Mvc;

namespace cw2_mysql.Controllers
{
    public class SchoolController : Controller
    {
        // GET: SchoolController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult StudentsList()
        {
            return View();
        }

    }
}
