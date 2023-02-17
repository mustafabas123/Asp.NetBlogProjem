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
    
    public class ContactController : Controller
    {
        ContactManager _contactManager=new ContactManager(new EfContactDAL());
        MyContactManager _myContactManager=new MyContactManager();

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(Contact c)
        {
            ContactValidation validationRules= new ContactValidation();
            ValidationResult result=validationRules.Validate(c);
            if (result.IsValid)
            {
                c.ContactDate = DateTime.Now;
                _contactManager.AddContact(c);
                return RedirectToAction("Index", "Contact");
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
        [AllowAnonymous]
        public PartialViewResult MyContactPartials()
        {
            var values = _myContactManager.GetAll();
            return PartialView(values);
        }
        public ActionResult AdminPanelMessage()
        {
            var values=_contactManager.GetList();
            return View(values);
        }
        public ActionResult MessageDetail(int id)
        {
            var value = _contactManager.FindContact(id);
            return View(value);
        }

    }
}