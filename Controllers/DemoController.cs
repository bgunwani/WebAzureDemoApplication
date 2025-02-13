using Microsoft.AspNetCore.Mvc;

namespace WebAzureDemoApplication.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
