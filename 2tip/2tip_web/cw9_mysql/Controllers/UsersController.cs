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
            var users = _usersRepo.GetUsersWithRoles();
            return View(users);
        }
        public IActionResult UserInfo(int id){
            var user = _usersRepo.GetUserById(id);
            if(user == null){
                return RedirectToAction("List");
            }
            return View(user);
        }
        
    }
}
