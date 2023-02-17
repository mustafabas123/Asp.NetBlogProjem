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
    public class CategoryManager:ICategoryService
    {
        Repository<Category> RCategory=new Repository<Category>();
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL= categoryDAL;
        }

        public List<Category> GetAll()
        {
            return _categoryDAL.getAll();
        }
        public Category FindCategory(int id)
        {
            Category c= _categoryDAL.Find(x=>x.CategoryId==id);
            return c;
        }
        public void CategoryStatusToFalse(int id)
        {
            var value = _categoryDAL.getById(id);
            value.CategoryStatus = false;
            _categoryDAL.update(value);
        }
        public void CategoryStatusToTrue(int id)
        {
            var value = _categoryDAL.getById(id);
            value.CategoryStatus = true;
            _categoryDAL.update(value);
        }
        public List<Category> ListCategoryStatusTrue()
        {
            return _categoryDAL.getAll().Where(x => x.CategoryStatus == true).ToList();
        }

        public List<Category> GetList()
        {
            return _categoryDAL.getAll();
        }

        public void CategoryAdd(Category category)
        {
            _categoryDAL.insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDAL.delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDAL.update(category);
        }

        public Category GetById2(int id)
        {
           return  _categoryDAL.getById(id);
        }
    }
}
