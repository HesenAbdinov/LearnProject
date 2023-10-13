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
            return _productRepository.Add(product);
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

        public List<Product> GetByCategoryId(int id)
        {
            return _productRepository.GetAll(d => d.CategoryID == id);
        }

        public Product GetById(int id)
        {
            return _productRepository.Get(d => d.Id == id);
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
