using cw8.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw8.Controllers
{
    public class CarController : Controller
    {
        // GET: CarController
        public ActionResult Index()
        {            
            return View(CarsRepo.GetCars());
        }

    }
}
