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
    public class AuthorController : Controller
    {

        BlogManager _blogManager = new BlogManager(new EfBlogDAL());
        AuthorManager _authorManager=new AuthorManager(new EfAuthorDAL());

        [AllowAnonymous]
        public PartialViewResult AuthorAboutPartial(int id)
        {
            var values = _blogManager.GetById(id); 
            return PartialView(values);
        }
        [AllowAnonymous]
        public PartialViewResult AuthorPopulerPost(int id)
        {
            var BlogAuthorId=_blogManager.GetList().Where(x=>x.BlogId==id).Select(x=>x.AuthorId).FirstOrDefault();
            var values =_blogManager.GetAuthorIdById(BlogAuthorId);
            return PartialView(values);
        }
        [AllowAnonymous]
        public PartialViewResult MeetTheTeam()
        {
            var values = _authorManager.GetList();
            return PartialView(values);
        }

        [HttpGet]
        public ActionResult GetAuthor()
        {
            var values =_authorManager.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author a)
        {
            AuthorValidation authorValidation=new AuthorValidation();
            ValidationResult result = authorValidation.Validate(a);
            if (result.IsValid)
            {
                _authorManager.AuthorAdd(a);
                return RedirectToAction("GetAuthor", "Author");
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
        public ActionResult UpdateAuthor(int id)
        {
            var value = _authorManager.GetById(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateAuthor(Author a)
        {
            AuthorValidation authorValidation=new AuthorValidation();
            ValidationResult result=authorValidation.Validate(a);
            if (result.IsValid)
            {
                _authorManager.AuthorUpdate(a);
                return RedirectToAction("GetAuthor", "Author");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }


        public ActionResult GetBlogByAuothorId(int id)
        {
            var values = _blogManager.GetById(id);
            return View(values);
        }
    }
}