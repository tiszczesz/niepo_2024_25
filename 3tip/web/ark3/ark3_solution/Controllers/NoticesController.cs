using ark3_solution.Models;
using Microsoft.AspNetCore.Mvc;

namespace ark3_solution.Controllers
{
    public class NoticesController : Controller
    {
        private readonly NoticesRepo _noticesRepo;
        public NoticesController(IConfiguration configuration)
        {
            _noticesRepo = new NoticesRepo(configuration);
        }
        // GET: NoticesController
        public ActionResult List()
        {
            return View();
        }

    }
}
