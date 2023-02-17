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
    public class SubscribeController : Controller
    {

        SubscribeManager _subscribeManager = new SubscribeManager(new EfSubscribeDAL());

        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult AddSubscribePartail()
        {
            return PartialView();
        }


    }
}