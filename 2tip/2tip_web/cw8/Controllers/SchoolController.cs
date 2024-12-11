using Microsoft.AspNetCore.Mvc;

namespace cw8.Controllers
{
    public class SchoolController : Controller
    {
        // GET: SchoolController
        public ActionResult List()
        {
            List<string> classes = new List<string> { "Math", "Physics", "Chemistry" };
            return View(classes);
        }

    }
}
