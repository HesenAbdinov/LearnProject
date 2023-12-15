using LearnProject.Entity.Concrete;
using System.Web.Mvc;

namespace LearnProject.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public Product? Product { get; set; }
        public List<Product>? Products { get; set; }
        public List<SelectListItem>? Categories { get; set; }
    }
}
