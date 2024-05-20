using Microsoft.AspNetCore.Mvc;

namespace Pigga_WebApp.Areas.Manage.Controllers
{
    public class ChefController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
