using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
