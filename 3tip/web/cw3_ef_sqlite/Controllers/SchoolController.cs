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
        //wyswietlenie formularza dodawania studenta
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        //dodanie studenta do bazy danych
        [HttpPost]          
        public IActionResult AddStudent(Student student)
        {
            if(ModelState.IsValid){
                //ustawia entity jako dodana
                //dodaje do kontekstu
                _context.Students.Add(student);
                //zapisuje zmiany w bazie danych
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteStudent(int id){

            return RedirectToAction("Index");
        }

    }
}
