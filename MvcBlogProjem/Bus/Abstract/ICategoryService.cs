using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAdd(Category category);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
        Category GetById2(int id);
    }
}
