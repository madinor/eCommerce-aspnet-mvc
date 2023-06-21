using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
