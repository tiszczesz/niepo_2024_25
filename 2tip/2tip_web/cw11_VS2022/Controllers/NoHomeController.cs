using cw11_VS2022.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw11_VS2022.Controllers
{
    public class NoHomeController : Controller {
        private readonly RepoNoTable _repo;

        public NoHomeController(IConfiguration configuration) {
            _repo = new RepoNoTable(configuration);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() {
            return View();
        }
    }
}
