using ark3_solution.Models;
using Microsoft.AspNetCore.Mvc;

namespace ark3_solution.Controllers
{
    public class OtherController : Controller
    {
        private readonly NoticesRepo _noticesRepo;
        public OtherController(IConfiguration configuration)
        {
            _noticesRepo = new NoticesRepo(configuration);
        }
       
        // GET: OtherController
        public ActionResult NoticesList()
        {
            List<NoticeFull> notices = _noticesRepo.GetNoticesFull();
            return View(notices);
        }
        [HttpGet]
        public ActionResult AddNotice()
        {
            ViewBag.Categories = _noticesRepo.GetCategories();
            ViewBag.SubCategories = _noticesRepo.GetSubCategories();
            ViewBag.Users = _noticesRepo.GetUsers();
            return View();
        }
        [HttpPost]
        public ActionResult AddNotice(NoticeFull notice)
        {
            ViewBag.Categories = _noticesRepo.GetCategories();
            ViewBag.SubCategories = _noticesRepo.GetSubCategories();
            ViewBag.Users = _noticesRepo.GetUsers();
            if (!ModelState.IsValid)
            {
                return View(notice);
            }
            _noticesRepo.SaveNotice(notice);
            return RedirectToAction("NoticesList");
        }

    }
}
