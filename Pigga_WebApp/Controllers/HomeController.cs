using Microsoft.AspNetCore.Mvc;


namespace Pigga_WebApp.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }

     
    }
}