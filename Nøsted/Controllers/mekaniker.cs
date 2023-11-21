using Microsoft.AspNetCore.Mvc;

namespace Nøsted.Controllers
{
    public class mekaniker : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
