using Microsoft.AspNetCore.Mvc;

namespace LearnProject.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
