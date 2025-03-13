using Microsoft.AspNetCore.Mvc;

namespace cw9_mysql.Controllers
{
    public class UsersController : Controller
    {
        private readonly UsersRepo _usersRepo;
        public UsersController(IConfiguration configuration)
        {
            _usersRepo = new UsersRepo(configuration);
        }
        // GET: UsersController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult List(){
            var users = _usersRepo.GetUsers();
            return View(users);
        }

    }
}
