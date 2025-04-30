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
        public IActionResult List()
        {
            var cars = _carsRepo.GetAllCars();
            return View(cars);
        }

        [HttpGet]
        public IActionResult CarRent(int? id)
        {
            if (id == null)
            {
                //powrot do listy gdy id==null
                // return RedirectToAction("List");
                return RedirectToAction(nameof(List));
            }
            var car = _carsRepo.GetCarById(id.Value);
            if (car == null)
            {
                //powrot do listy gdy id nie istnieje
                return RedirectToAction(nameof(List));
            }
            CarUserViewModel carUser = new CarUserViewModel();
            carUser.CarToRental = car;
            return View(carUser);
        }
        [HttpPost]
        public IActionResult PostCarRental(CarUserViewModel carUser)
        {
            if (ModelState.IsValid)
            {
               
                return RedirectToAction(nameof(List));
            }
            //return View("CarRent", carUser);      
        
            return View();
        }

    }
}
