using Microsoft.AspNetCore.Mvc;

namespace cw10_cars.Controllers
{
    public class CarsRentalController : Controller
    {
        // GET: CarsRentalController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult List(){
            return View();
        }

    }
}
