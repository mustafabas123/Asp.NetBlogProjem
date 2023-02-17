using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Concerete
{
    public class AdminAuthorManger
    {
        Repository<Author> RAdminAuthor=new Repository<Author>();
        Repository<Blog> RBlog=new Repository<Blog>();
        public Author FindAuthorByMail(string p)
        {
            Author a= RAdminAuthor.Find(x => x.AuthorMail == p);
            return a;
        }
        public List<Author> GetAuthorByMail(string p)
        {
            return RAdminAuthor.getAll().Where(x=>x.AuthorMail== p).ToList();
        }
        public List<Blog> GetBlogByAuthorId(int id)
        {
            return RBlog.getAll().Where(x=>x.AuthorId== id).ToList(); 
        }
    }
}
