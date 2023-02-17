using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> getAll();
        void insert(T t);
        void update(T t);
        void delete(T t);
        T getById(int id);
        List<T> findById(Expression<Func<T,bool>> where);
        List<T> findAuthorIdById(Expression<Func<T, bool>> where);
        List<T> GetPostByCategory(Expression<Func<T, bool>> where);
        T Find(Expression<Func<T, bool>> where);
    }
}
