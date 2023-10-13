using LearnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //SİNXRON
        T Add(T entity);

        T Update(T entity);

        void Delete(T entity);

        T Get(Expression<Func<T, bool>> filter = null);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);


        //ASİNXRON
        Task<T> UpdateAsync(T entity);

        Task<T> AddAsync(T entity);

        Task DeleteAsync(T entity);

    }
}
