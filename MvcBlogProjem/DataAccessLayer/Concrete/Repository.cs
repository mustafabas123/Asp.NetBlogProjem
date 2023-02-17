using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {

        Context context=new Context();
        DbSet<T> set;
        public Repository()
        {
            set=context.Set<T>();
        }
        public void delete(T t)
        {
            var values = context.Entry(t);
            values.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
           return set.FirstOrDefault(where);
        }

        public List<T> findAuthorIdById(Expression<Func<T, bool>> where)
        {
            return set.Where(where).ToList();
        }

        public List<T> findById(Expression<Func<T, bool>> where)
        {
            return set.Where(where).ToList();
        }

        public List<T> getAll()
        {
           return set.ToList();
        }

        public T getById(int id)
        {
           return set.Find(id);
        }

        public List<T> GetPostByCategory(Expression<Func<T, bool>> where)
        {
            return set.Where(where).ToList();
        }

        public void insert(T t)
        {
            var values = context.Entry(t);
            values.State = EntityState.Added;
            context.SaveChanges();
        }

        public void update(T t)
        {
            var values = context.Entry(t);
            values.State = EntityState.Modified;
           context.SaveChanges();
        }
    }
}
