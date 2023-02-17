using Bus.Concerete;
using Bus.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProjem.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _category=new CategoryManager(new EfCategoryDAL());
        public ActionResult Index()
        {
            var value=_category.GetAll();
            return View(value);
        }
        [AllowAnonymous]
        public PartialViewResult BlogDetailCategoryList()
        {
            var value=_category.GetAll();
            return PartialView(value);
        }

        [HttpGet]
        public ActionResult AdminCategoryList()
        {
            var values=_category.GetAll();
            return View(values);
        }
        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(Category c)
        {
            CategoryValidation validationRules= new CategoryValidation();
            ValidationResult result=validationRules.Validate(c);
            if (result.IsValid)
            {
                _category.CategoryAdd(c);
                return RedirectToAction("AdminCategoryList");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = _category.GetById2(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category c)
        {
            CategoryValidation validationRules = new CategoryValidation();
            ValidationResult result=validationRules.Validate(c);
            if(result.IsValid)
            {
                _category.CategoryUpdate(c);
                return RedirectToAction("AdminCategoryList");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        public ActionResult CategoryStatusToFalse(int id)
        {
            _category.CategoryStatusToFalse(id);
            return RedirectToAction("AdminCategoryList");
        }
        public ActionResult CategoryStatusToTrue(int id)
        {
            _category.CategoryStatusToTrue(id);
            return RedirectToAction("AdminCategoryList");
        }
    }
}