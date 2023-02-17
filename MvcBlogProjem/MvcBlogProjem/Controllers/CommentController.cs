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
    public class CommentController : Controller
    {

        CommentManager _commentManager=new CommentManager(new EfCommentDAL());

        [AllowAnonymous]
        public PartialViewResult CommentListPartial(int id)
        {
            var value = _commentManager.getById(id);
            return PartialView(value);
        }

        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult CommentLeavePartial(int id)
        {
            ViewBag.Mustafa = id;
            return PartialView();
        }
        [HttpGet]
        public ActionResult CommentAdminListTrue()
        {
            var values = _commentManager.GetCommentsByStatusTrue();
            return View(values);
        }
        public ActionResult CommentChangeStatusFalse(int id)
        {
            _commentManager.CommetStatusToFalse(id);
            return RedirectToAction("CommentAdminListTrue", "Comment");
        }
        [HttpGet]
        public ActionResult CommentAdminListFalse()
        {
            var values=_commentManager.GetCommentsByStatusFalse();
            return View(values);
        }
        public ActionResult CommentChangeStausTrue(int id)
        {
            _commentManager.CommetStatusToTrue(id);
            return RedirectToAction("CommentAdminListFalse", "Comment");
        }
        [AllowAnonymous]
        public PartialViewResult DropComment()
        {
            return PartialView();
        }

    }
}