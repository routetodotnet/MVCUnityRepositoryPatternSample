using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessService
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);

        IQueryable<T> GetAll();

        IQueryable<T> GetAll(int index, int count);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
