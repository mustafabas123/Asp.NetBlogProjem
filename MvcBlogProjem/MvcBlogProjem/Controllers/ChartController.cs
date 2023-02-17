using DataAccessLayer.Concrete;
using MvcBlogProjem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProjem.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChartCategoryBlog()
        {
            return Json(categoryList(),JsonRequestBehavior.AllowGet);
        }
        public List<Class1> categoryList()
        {
            List<Class1> c=new List<Class1>();
            c.Add(new Class1()
            {
                CaetegoryName="Spor",
                BlogCount=10
            });
            c.Add(new Class1()
            {
                CaetegoryName="Teknoloji",
                BlogCount=5
            });
            c.Add(new Class1()
            {
                CaetegoryName = "Seyehat",
                BlogCount = 5
            });
            c.Add(new Class1()
            {
                CaetegoryName="Kültür Sanat",
                BlogCount=20
            });
            return c;
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult ChartCategoryBlog2()
        {
            return Json(categoryList2(),JsonRequestBehavior.AllowGet);
        }
        public List<Class2> categoryList2()
        {
            List<Class2> cs2=new List<Class2>();
            using (var c = new Context()){
                cs2=c.Blogs.Select(x=>new Class2
                {
                    CategoryName=x.Title,
                    Rating=x.BlogRating
                }).ToList();
            }

            return cs2;

        }
    }
}