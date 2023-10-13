using LearnProject.Business.Abstract;
using LearnProject.DataAccess.Abstract;
using LearnProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Business.Concrete.Managers
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public Category Add(Category category)
        {
            return _categoryRepository.Add(category);
        }

        public async Task<Category> AddAsync(Category category)
        {
            return await _categoryRepository.AddAsync(category);
        }

        public Category Update(Category category)
        {
            return _categoryRepository.Update(category);
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            return await _categoryRepository.UpdateAsync(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.Get(d => d.Id == id);
        }
    }
}
