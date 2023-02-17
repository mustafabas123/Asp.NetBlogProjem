using Bus.Concerete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProjem.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        AboutManager _aboutManager=new AboutManager(new EfAboutDAL());
        SocailMediaManager _socailMediaManager=new SocailMediaManager();
        public ActionResult Index()
        {
            var values=_aboutManager.GetList();
            return View(values);
        }
        public PartialViewResult Footer()
        {
            var values=_aboutManager.GetList();
            return PartialView(values);
        }
        public PartialViewResult AdminSocialMedia()
        {
            var values = _socailMediaManager.GetAll();
            return PartialView(values);
        }
        [HttpGet]
        public ActionResult AdminAbout()
        {
            var values =_aboutManager.GetList();
            return View(values);
        }
        [HttpPost]
        public ActionResult AdminAbout(About a)
        {
            _aboutManager.EditAbout(a);
            return RedirectToAction("AdminAbout", "About");
        }
    }
}