using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcBlogProjem.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AuthorLogin(Author a)
        {
            Context c = new Context();
            var AuthorInfo = c.Authors.FirstOrDefault(x => x.AuthorMail == a.AuthorMail && x.AuthorPassword == a.AuthorPassword);
            if(AuthorInfo != null)
            {
                FormsAuthentication.SetAuthCookie(AuthorInfo.AuthorMail, false);
                Session["Mail"] = AuthorInfo.AuthorMail.ToString();
                return RedirectToAction("Index", "AdminAuthor");
            }

            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }

        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin a)
        {
            Context c = new Context();
            var AdminInfo = c.Admins.FirstOrDefault(x => x.Username == a.Username && x.Password == a.Password);
            if(AdminInfo != null)
            {
                FormsAuthentication.SetAuthCookie(AdminInfo.Username, false);
                Session["Username"]=AdminInfo.Username.ToString();
                return RedirectToAction("AdminPanelBlog", "Blog");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }
        }
        public ActionResult LoginOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login", "AdminLogin");
        }
    }
}