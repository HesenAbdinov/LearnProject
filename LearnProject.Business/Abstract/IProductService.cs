using LearnProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Business.Abstract
{
    public interface IProductService
    {
        Product Add(Product product);

        Task<Product> AddAsync(Product product);

        Product Update(Product product);

        Task<Product> UpdateAsync(Product product);

        void Delete(Product product);

        Product GetById(int id);

        Product GetByName(string name);

        List<Product> GetAll();
        List<Product> GetAllWithCategory();

        List<Product> GetByCategoryId(int id);
    } 
}
