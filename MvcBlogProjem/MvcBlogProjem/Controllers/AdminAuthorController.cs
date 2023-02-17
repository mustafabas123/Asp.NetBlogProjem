using Bus.Concerete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebGrease;

namespace MvcBlogProjem.Controllers
{
    public class AdminAuthorController : Controller
    {
        AdminAuthorManger _adminAuthorManger=new AdminAuthorManger();
        BlogManager _BlogManager=new BlogManager(new EfBlogDAL());
        AuthorManager _authorManager=new AuthorManager(new EfAuthorDAL());
        public ActionResult Index(string p)
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult UpdateAuthor(string p)
        {
            p = (string)Session["Mail"];
            var values = _adminAuthorManger.GetAuthorByMail(p);
            return PartialView(values);
        }

        public PartialViewResult GetAuthorName(string p)
        {
            p = (string)Session["Mail"];
            var values = _adminAuthorManger.GetAuthorByMail(p);
            return PartialView(values);
        }
        [HttpPost]
        public ActionResult UpdateAuthor(Author a)
        {
            _authorManager.AuthorUpdate(a);
            return RedirectToAction("Index", "AdminAuthor");
        }
        public ActionResult BlogList(string p)
        {
            p = (string)Session["Mail"];
            Context c=new Context();            
            int id=c.Authors.Where(x=>x.AuthorMail == p).Select(y=>y.AuthorId).FirstOrDefault();
            var values = _adminAuthorManger.GetBlogByAuthorId(id);
            return View(values);
        }



        [HttpGet]
        public ActionResult AddPost(string p)
        {
            Context c = new Context();
            p = (string)Session["Mail"];
            int id =c.Authors.Where(x=>x.AuthorMail ==p).Select(y=>y.AuthorId).FirstOrDefault();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString(),
                                           }).ToList();


            ViewBag.v1 = values;
            ViewBag.v2 = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddPost(Blog b)
        {
            _BlogManager.BlogAdd(b);
            return RedirectToAction("BlogList", "AdminAuthor");
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString(),
                                           }).ToList();

            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorId.ToString(),
                                            }).ToList();
            ViewBag.v1 = values;
            ViewBag.v2 = values2;
            var value = _BlogManager.FindBlog(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog b)
        {
            _BlogManager.BlogUpdate(b);
            return RedirectToAction("BlogList", "AdminAuthor");
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("AuthorLogin", "Login");
        }


    }
}