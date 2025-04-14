using cw3_ef_sqlite.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw3_ef_sqlite.Controllers
{
    public class SchoolController : Controller
    {
        private SchoolContext _context;
        public SchoolController(SchoolContext context)
        {
            _context = context;
        }
        // GET: SchoolController
        public ActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

    }
}
