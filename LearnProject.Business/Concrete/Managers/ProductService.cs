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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product Add(Product product)
        {
            return _productRepository.AddSaveChanges(product);
        }

        public async Task<Product> AddAsync(Product product)
        {
            return await _productRepository.AddAsync(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public List<Product> GetAllWithCategory()
        {
            return _productRepository.GetAllWithCategory();
        }

        public List<Product> GetByCategoryId(int id)
        {
            return _productRepository.GetAll(p => p.CategoryID == id);
        }

        public Product GetById(int id)
        {
            return _productRepository.Get(p => p.Id == id);
        }

        public Product GetByName(string name)
        {
            return _productRepository.Get(p => p.Name == name);
        }

        public Product Update(Product product)
        {
            return _productRepository.Update(product);
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            return await _productRepository.UpdateAsync(product);
        }
    }
}
