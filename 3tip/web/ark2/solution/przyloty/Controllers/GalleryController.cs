using Microsoft.AspNetCore.Mvc;

namespace przyloty.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public GalleryController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        // GET: GalleryController
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormFile file)
        {
            string? uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }
            if (file != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                file.CopyToAsync(new FileStream(filePath, FileMode.Create));
            }
            return RedirectToAction("Index");
        }

    }
}
