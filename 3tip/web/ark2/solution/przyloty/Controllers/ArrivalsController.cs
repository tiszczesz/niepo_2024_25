using Microsoft.AspNetCore.Mvc;
using przyloty.Models;

namespace przyloty.Controllers
{
    public class ArrivalsController : Controller
    {
        private readonly ArrivalsRepo _repo;
        public ArrivalsController(IConfiguration configuration)
        {
            // Set a cookie

            _repo = new ArrivalsRepo(configuration);
        }

        // GET: ArrivalsController
        public ActionResult List()
        {

            if (HttpContext.Request.Cookies.ContainsKey("Welcome"))
            {
                var cookieValue = HttpContext.Request.Cookies["Welcome"];
                ViewBag.CookieValue = cookieValue;
            }
            else
            {
                HttpContext.Response.Cookies.Append("Welcome", "true", new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(1)
                });
                ViewBag.CookieValue = "false";
            }

            var arrivals = _repo.GetArrivals();
            return View(arrivals);
        }

    }
}
