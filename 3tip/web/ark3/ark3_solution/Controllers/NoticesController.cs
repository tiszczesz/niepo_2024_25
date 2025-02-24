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
        
        [HttpGet]
        public ActionResult List()
        {
            List<Category> categories = _noticesRepo.GetCategories();
            List<SubCategory> subCategories = _noticesRepo.GetSubCategories();
            ViewBag.SubCategories = subCategories;
            ViewBag.Categories = categories;
            return View();
        }
        [HttpPost]
        public ActionResult List(User user)
        {
            List<Category> categories = _noticesRepo.GetCategories();
            List<SubCategory> subCategories = _noticesRepo.GetSubCategories();
            ViewBag.SubCategories = subCategories;
            ViewBag.Categories = categories;
            if(ModelState.IsValid)
            {
                // zapis do bazy
                _noticesRepo.SaveUser(user);
            }
            return View(user);
        }

    }
}
