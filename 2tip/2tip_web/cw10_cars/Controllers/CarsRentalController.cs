using cw10_cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw10_cars.Controllers
{
    public class CarsRentalController : Controller
    {
        private readonly CarsRepo _carsRepo;
        public CarsRentalController(IConfiguration configuration)
        {
            _carsRepo = new CarsRepo(configuration);
        }
   
        // GET: CarsRentalController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult List(){
            var cars = _carsRepo.GetAllCars();
            return View(cars);
        }

    }
}
