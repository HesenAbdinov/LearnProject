using LearnProject.Core.DataAccess.EFCore;
using LearnProject.DataAccess.Abstract;
using LearnProject.DataAccess.Concrete.EFCore.DataBaseContext;
using LearnProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.DataAccess.Concrete.EFCore
{
    public class CategoryRepository : EfEntityRepositoryBase<Category, LearnProjectDbContext>, ICategoryRepository
    {
    }
}
