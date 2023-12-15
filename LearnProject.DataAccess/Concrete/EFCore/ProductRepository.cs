using LearnProject.Core.DataAccess.EFCore;
using LearnProject.Core.Entities;
using LearnProject.DataAccess.Abstract;
using LearnProject.DataAccess.Concrete.EFCore.DataBaseContext;
using LearnProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.DataAccess.Concrete.EFCore
{
    public class ProductRepository : EfEntityRepositoryBase<Product, LearnProjectDbContext>, IProductRepository
    {
        public List<Product> GetAllWithCategory(Expression<Func<Product, bool>> filter = null)
        {
            using (var context = new LearnProjectDbContext())
            {
                return filter == null
                    ? context.Set<Product>().Include(x => x.Category).ToList()
                    : context.Set<Product>().Where(filter).Include(x => x.Category).ToList();
            }
        }
    }
}
