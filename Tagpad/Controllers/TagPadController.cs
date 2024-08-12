using Microsoft.AspNetCore.Mvc;

namespace Tagpad.Controllers
{
    public class TagPadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
