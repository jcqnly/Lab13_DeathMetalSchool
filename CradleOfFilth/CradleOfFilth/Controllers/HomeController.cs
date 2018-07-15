using Microsoft.AspNetCore.Mvc;

namespace CradleOfFilth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}