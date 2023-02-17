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
    public  class AuthorManager:IAuthorService
    {
        IAuthorDAL _authorDAL;
        public AuthorManager(IAuthorDAL authorDAL)
        {
            _authorDAL= authorDAL;
        }
        public List<Author> GetList()
        {
            return _authorDAL.getAll();
        }

        public void DeleteAuthor(Author author)
        {
            _authorDAL.delete(author);
        }

        public Author GetById(int id)
        {
            return _authorDAL.getById(id);
        }

        public void AuthorAdd(Author author)
        {
            _authorDAL.insert(author);
        }

        public void AuthorUpdate(Author author)
        {
            _authorDAL.update(author);
        }
    }
}
