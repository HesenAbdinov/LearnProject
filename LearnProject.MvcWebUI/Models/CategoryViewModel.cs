using LearnProject.Entity.Concrete;

namespace LearnProject.MvcWebUI.Models
{
    public class CategoryViewModel
    {
        public Category? Category { get; set; }
        public List<Category>? Categories { get; set; }
    }
}
