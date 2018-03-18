using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    public class ProductsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}