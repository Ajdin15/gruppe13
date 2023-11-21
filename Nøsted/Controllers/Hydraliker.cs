using Microsoft.AspNetCore.Mvc;

namespace Nøsted.Controllers
{
    public class Hydraliker : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
