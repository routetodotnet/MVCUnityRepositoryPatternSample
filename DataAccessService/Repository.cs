using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessService
{
 
    public class Repository<T> : IRepository<T> where T : class
    {

        public DbContext context;
        public DbSet<T> dbset;
        public Repository(DbContext context)
        {
            this.context = context;
            dbset = context.Set<T>();
        }

        public T GetById(int id)
        {
            return dbset.Find(id);
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate).AsEnumerable<T>();
        }
     

        public void Insert(T entity)
        {
            dbset.Add(entity);
        }


        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }


        public void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }

        public IQueryable<T> GetAll(int index, int count)
        {
            return dbset.Take(count);
        }

        public IQueryable<T> GetAll()
        {
            return dbset;
        }
    }


}
