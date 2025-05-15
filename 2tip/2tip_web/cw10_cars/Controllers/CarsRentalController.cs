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
                //zapisanie do bazy danych do tabelki zamowienie
                _carsRepo.AddCarRental(carUser.User);
                return RedirectToAction(nameof(ShowallOrders));
            }
            //jesli niepoprawne dane to zwracamy do widoku
            var car = _carsRepo.GetCarById(carUser.User.CarId);
            carUser.CarToRental = car;
            return View("CarRent", carUser);
        }
        public IActionResult ShowallOrders()
        {
            return View();
        }

        public IActionResult PartialShow()
        {
            var list = new List<string>(){
                "Zamówienie 1",
                "Zamówienie 2",
                "Zamówienie 3",
                "Zamówienie 4",
                "Zamówienie 5"
            };
            // return PartialView("_MainPartial",list);
            return View(list);
        }
        
        

    }
}
