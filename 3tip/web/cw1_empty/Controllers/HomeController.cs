using cw1_empty.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw1_empty.Controllers
{
    public class HomeController : Controller
    {
        private readonly MoviesRepo _repo;
        public HomeController(IConfiguration configuration){
            _repo = new MoviesRepo(configuration);
        }
        // GET: HomeController
        public ActionResult Index()
        {
            var movies = _repo.GetMovies();
            return View(movies);
        }

    }
}
