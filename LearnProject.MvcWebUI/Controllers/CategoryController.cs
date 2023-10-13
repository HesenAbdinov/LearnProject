using LearnProject.Business.Abstract;
using LearnProject.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearnProject.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;

        public CategoryController(ILogger<HomeController> logger,ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }
        public IActionResult GetCategories()
        {
            var categoryViewModel = new CategoryViewModel()
            {
                Categories = _categoryService.GetAll()
            };

            return View(categoryViewModel);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
