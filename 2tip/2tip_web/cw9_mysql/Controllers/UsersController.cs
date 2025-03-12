using Microsoft.AspNetCore.Mvc;

namespace cw9_mysql.Controllers
{
    public class UsersController : Controller
    {
        private readonly UsersRepo _usersRepo;
        // GET: UsersController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult List(){
            return View();
        }

    }
}
