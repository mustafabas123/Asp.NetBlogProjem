using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetList();
        void AuthorAdd(Author author);
        void DeleteAuthor(Author author);
        void AuthorUpdate(Author author);
        Author GetById(int id);
    }
}
