using cw2_mysql.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw2_mysql.Controllers
{
    public class SchoolController : Controller
    {
        private readonly StudentsRepo _repo;
        public SchoolController(IConfiguration configuration)
        {
            _repo =  new StudentsRepo(configuration);
        }
        // GET: SchoolController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult GroupsList(){
            var groups = _repo.GetGroups();
            return View(groups);
        }
        public IActionResult StudentsList()
        {
            var students = _repo.GetStudents();
            return View(students);
        }
        public IActionResult StudentsGroup(int? id)
        {
            if(id == null) return RedirectToAction(nameof(GroupsList));
            //if(id == null) return RedirectToAction("GroupsList");
            var students = _repo.GetStudentsByGroup(id);
            Group? group = _repo.GetGroupById(id);
            ViewBag.Group = group;
            return View(students);
        }

    }
}
