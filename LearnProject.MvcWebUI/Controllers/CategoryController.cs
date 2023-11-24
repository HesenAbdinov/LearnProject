using LearnProject.Business.Abstract;
using LearnProject.Entity.Concrete;
using LearnProject.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearnProject.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _categoryService;

        public CategoryController(ILogger<CategoryController> logger,ICategoryService categoryService)
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

        public IActionResult Add(CategoryViewModel categoryViewModel)
        {
            if(ModelState.IsValid)
            {
                var categoryForAdd = new Category
                {
                    AddedBy = "Hasan Abdinov",
                    AddedDate = DateTime.Now,
                    IsActive = true,
                    Name = categoryViewModel?.Category?.Name
                };

                try
                {
                    _categoryService.AddSaveChanges(categoryForAdd);
                    return RedirectToAction("GetCategories");
                }
                catch (Exception)
                {
                    return RedirectToAction("Error");
                }
            }
            return RedirectToAction("GetCategories");
        }
        [HttpGet]
        public JsonResult Edit(int id)
        {
            if(id==0)
            {
                return Json(0);
            }
            var category = _categoryService.GetById(id);
            if(category == null)
            {
                return Json(0);
            }
            return Json(category);
        }

        [HttpPost]
        public IActionResult Edit (CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                var categoryIsValid= _categoryService.GetById(categoryViewModel.Category.Id);
                
                if (categoryIsValid == null)
                {
                    return RedirectToAction("GetCategories");
                }
                try
                {
                    var categoryForEdit = new Category
                    {
                        AddedBy = categoryIsValid.AddedBy,
                        AddedDate = categoryIsValid.AddedDate,
                        Id = categoryIsValid.Id,
                        IsActive = categoryViewModel.Category.IsActive,
                        Name = categoryViewModel.Category.Name
                    };
                    _categoryService.Update(categoryForEdit);
                    return RedirectToAction("GetCategories");
                }
                catch (Exception)
                {
                    return RedirectToAction("GetCategories");

                }
            }
            return RedirectToAction("GetCategories");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
