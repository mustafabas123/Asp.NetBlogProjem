using Bus.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Concerete
{
    public class BlogManager:IBlogService
    {
        Repository<Blog> RBlog=new Repository<Blog>();
        IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }
        public List<Blog> GetById(int id)
        {
            return _blogDAL.findById(x=>x.BlogId== id);
        }
        public List<Blog> GetAuthorIdById(int id)
        {
            return _blogDAL.findAuthorIdById(x=>x.AuthorId== id);
        }

        public List<Blog> GetPostByCaeogryId(int id)
        {
            return _blogDAL.GetPostByCategory(x=>x.CategoryId== id);
        }
        public void DeleteBlog(int id)
        {
            Blog b=_blogDAL.Find(x=>x.BlogId== id);
            _blogDAL.delete(b);
        }
        public Blog FindBlog(int id)
        {
           Blog b=_blogDAL.Find(x=>x.BlogId== id);
            return b;
        }
        public List<Blog> GetList()
        {
           return _blogDAL.getAll();
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDAL.update(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _blogDAL.delete(blog);
        }

        public void BlogAdd(Blog blog)
        {
            _blogDAL.insert(blog);
        }

        public Blog GetById2(int id)
        {
            return _blogDAL.getById(id);
        }
    }
}
