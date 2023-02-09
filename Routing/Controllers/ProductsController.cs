using Microsoft.AspNetCore.Mvc;
using Routing.Models;

namespace Routing.Controllers
{
    public class ProductsController : Controller
    {

        List<Product> Model = new List<Product>()
    {
    new Product() {Name = "Nierdzewny widelec", Description = "Wykonany ze stali nierdzewnej.", ProductId = 1 },
    new Product() { Name = "Stalowy widelec", Description = "Wykonany ze stali.", ProductId = 2 },
    new Product() { Name = "Zloty widelec", Description = "Wykonany ze zlota.", ProductId = 3 }
        };

        public IActionResult Index()
        {
            return View();
        }

        [Route("products/list")]
        public IActionResult List()
        {
            return View("List",Model);
        }

        [Route("products/details/{id?}")]
        public IActionResult Details(int id)
        {
            Product product = new Product();
            foreach(var products in Model)
            {
                if (products.ProductId == id) { product = products; }
            }
            return View("Details",product);
        }
    }
}
