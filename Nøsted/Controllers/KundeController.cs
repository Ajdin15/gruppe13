using Microsoft.AspNetCore.Mvc;

namespace Nøsted.Controllers
{
    public class KundeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
