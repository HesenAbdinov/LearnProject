using LearnProject.Business.Abstract;
using LearnProject.Business.Concrete.Managers;
using LearnProject.Entity.Concrete;
using LearnProject.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnProject.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductService productService, ICategoryService categoryService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _categoryService = categoryService;
            _logger = logger;
        }

        public IActionResult GetProducts()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = _productService.GetAllWithCategory(),
                Categories = _categoryService.GelCategoriestForSelectbox()
            };

            return View(productViewModel);
        }

        public IActionResult Add(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var productIsValid = _productService.GetByName(productViewModel.Product.Name);
                if (productIsValid != null)
                {
                    return RedirectToAction("GetProducts");
                }

                var productForAdd = new Product()
                {
                    //Statik data
                    AddedDate = DateTime.Now,
                    AddedBy = "Hasan Abdinov",

                    //Dynamic data
                    Name = productViewModel.Product.Name,
                    Width = productViewModel.Product.Width,
                    Height = productViewModel.Product.Height,
                    Weight = productViewModel.Product.Weight,
                    CategoryID = productViewModel.Product.CategoryID,
                    Explanation = productViewModel.Product.Explanation,
                };

                try
                {
                    _productService.Add(productForAdd);
                }
                catch (Exception ex)
                {
                    _logger.LogWarning(ex.Message, ex);
                    return RedirectToAction("GetProducts");
                }
            }

            return RedirectToAction("GetProducts");
        }

        [HttpGet]
        public JsonResult Edit(int id)
        {
            if (id > 0)
            {
                var product = _productService.GetById(id);
                if (product == null)
                {
                    return Json(0);
                }
                return Json(product);
            }
            return Json(0);
        }

        [HttpPost]
        public IActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var productIsValid = _productService.GetById(productViewModel.Product.Id);
                    if (productIsValid != null)
                    {
                        var productForEdit = new Product
                        {
                            //Date take from GetById()
                            Id = productIsValid.Id,
                            AddedBy = productIsValid.AddedBy,
                            AddedDate = productIsValid.AddedDate,
                            //Date take from view
                            Name = productViewModel.Product.Name,
                            Width = productViewModel.Product.Width,
                            Weight = productViewModel.Product.Weight,
                            Height = productViewModel.Product.Height,
                            CategoryID = productViewModel.Product.CategoryID,
                            Explanation = productViewModel.Product.Explanation
                        };
                        _productService.Update(productForEdit);
                    }
                }
                catch (Exception ex)
                {
                    return RedirectToAction("GetProducts");
                }
            }
            return RedirectToAction("GetProducts");
        }

        public IActionResult Delete(int id)
        {
            if (id == 0 || id == null)
            {
                return Json(0);
            }
            var productForDelete = _productService.GetById(id);
            if (productForDelete == null)
            {
                return Json(0);
            }
            try
            {
                _productService.Delete(productForDelete);
                return Json(1);
            }
            catch (Exception ex)
            {
                return Json(ex.Message.ToString());
            }
        }
    }
}
