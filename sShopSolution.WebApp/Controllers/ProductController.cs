using Microsoft.AspNetCore.Mvc;

namespace sShopSolution.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }
    }
}