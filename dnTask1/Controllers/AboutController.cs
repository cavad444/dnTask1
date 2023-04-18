using Microsoft.AspNetCore.Mvc;

namespace dnTask1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
