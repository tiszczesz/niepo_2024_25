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

    }
}
