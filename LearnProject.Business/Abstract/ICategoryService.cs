using LearnProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LearnProject.Business.Abstract
{
    public interface ICategoryService
    {
        Category Add(Category category);

        Category AddSaveChanges(Category category);

        Task<Category> AddAsync(Category category);

        Category Update(Category category);

        Task<Category> UpdateAsync(Category category);

        void Delete(Category category);

        Category GetById(int id);

        List<Category> GetAll();

        List<SelectListItem> GelCategoriestForSelectbox();
    }
}
