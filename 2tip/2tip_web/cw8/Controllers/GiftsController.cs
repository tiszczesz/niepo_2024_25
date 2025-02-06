using cw8.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw8.Controllers
{
    public class GiftsController : Controller
    {
        private readonly MyGiftsRepo _myGiftsRepo;
        public GiftsController()
        {
            _myGiftsRepo = new MyGiftsRepo();
        }
        // GET: GiftsController
        public ActionResult List()
        {
            return View(_myGiftsRepo.MyGifts);
        }
        [HttpGet]
        public IActionResult AddGift()
        {
            //wyświetlenie formularza pustego
            return View();
        }
        [HttpPost]
        public IActionResult AddGift(MyGift myGift)
        {
            if(ModelState.IsValid){
                //przetwarzanie danych z formularza
                _myGiftsRepo.MyGifts.Add(myGift);
                _myGiftsRepo.Save();
                return RedirectToAction("List");
            }            
            return View();
        }
        public IActionResult DeleteGift(int id){
            _myGiftsRepo.MyGifts.RemoveAt(id);            
            _myGiftsRepo.Save();
            return RedirectToAction("List");
        }

    }
}
