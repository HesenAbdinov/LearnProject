using LearnProject.Core.DataAccess;
using LearnProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.DataAccess.Abstract
{
    public interface IProductRepository : IEntityRepository<Product>
    {
    }
}
