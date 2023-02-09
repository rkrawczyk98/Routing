using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("products/list")]
        public IActionResult List()
        {
            return View();
        }

        [Route("products/details/")]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
