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
            //znajduje studenta o podanym id
            var student = _context.Students.Find(id);
            if(student != null){
                //usuwa studenta z kontekstu
                _context.Students.Remove(student);
                //zapisuje zmiany w bazie danych
                _context.SaveChanges();
            }           
        
            return RedirectToAction("Index");
        }
        //wyswietlenie formularza edytowania studenta
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            //znajduje studenta o podanym id
            var student = _context.Students.Find(id);
            if(student != null){
                return View(student);
            }
            return RedirectToAction("Index");
        }
        //edytowanie studenta w bazie danych
        [HttpPost]
        public IActionResult EditStudent(Student student)
        {
            if(ModelState.IsValid){
                //ustawia entity jako zmieniona
                //aktualizuje w kontekście
                _context.Students.Update(student);
                //zapisuje zmiany w bazie danych
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

    }
}
