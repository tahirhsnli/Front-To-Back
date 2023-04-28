using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}
