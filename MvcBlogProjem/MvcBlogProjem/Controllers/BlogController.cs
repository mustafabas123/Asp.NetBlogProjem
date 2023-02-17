using Bus.Concerete;
using Bus.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.Ajax.Utilities;
using PagedList;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Context = DataAccessLayer.Concrete.Context;

namespace MvcBlogProjem.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager _BlogManager=new BlogManager(new EfBlogDAL());
        CommentManager _commentManager=new CommentManager(new EfCommentDAL());
        SubscribeManager _subscribeManager=new SubscribeManager(new EfSubscribeDAL());

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogPartial(int Page=1) //Sayfalama işlemini kaçtan başlıycağını belirtmemizi sağlıyor
        {
            var values = _BlogManager.GetList().ToPagedList(Page,3);
            return PartialView(values);
        }

        public PartialViewResult BlogPartial2()
        {
            //Post 1
            var postTitle=_BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y=>y.CategoryId== 1).Select(z=>z.Title).FirstOrDefault();
            var postImage=_BlogManager.GetList().OrderByDescending(x=>x.BlogId).Where(y=>y.CategoryId==1).Select(z=>z.Image).FirstOrDefault();
            var postDate=_BlogManager.GetList().OrderByDescending(x=>x.BlogId).Where(y=>y.CategoryId == 1).Select(z=>z.BlogDate).FirstOrDefault();
            var postId=_BlogManager.GetList().OrderByDescending(x=>x.BlogId).Where(y=>y.CategoryId == 1).Select(z=>z.BlogId).FirstOrDefault();


            //Post 2
            var postTitle2 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 2).Select(z => z.Title).FirstOrDefault();
            var postImage2= _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 2).Select(z => z.Image).FirstOrDefault();
            var postDate2 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 2).Select(z => z.BlogDate).FirstOrDefault();
            var postId2 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 2).Select(z => z.BlogId).FirstOrDefault();

            //Post 3
            var postTitle3 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 3).Select(z => z.Title).FirstOrDefault();
            var postImage3 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 3).Select(z => z.Image).FirstOrDefault();
            var postDate3 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 3).Select(z => z.BlogDate).FirstOrDefault();
            var postId3=_BlogManager.GetList().OrderByDescending(x=>x.BlogId).Where(y=>y.CategoryId==3).Select(z=>z.BlogId).FirstOrDefault();

            //Post 3
            var postTitle4 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 4).Select(z => z.Title).FirstOrDefault();
            var postImage4 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 4).Select(z => z.Image).FirstOrDefault();
            var postDate4  = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 4).Select(z => z.BlogDate).FirstOrDefault();
            var postId4 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 4).Select(z => z.BlogId).FirstOrDefault();

            //Post 3
            var postTitle5 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 5).Select(z => z.Title).FirstOrDefault();
            var postImage5 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 5).Select(z => z.Image).FirstOrDefault();
            var postDate5 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 5).Select(z => z.BlogDate).FirstOrDefault();
            var postId5 = _BlogManager.GetList().OrderByDescending(x => x.BlogId).Where(y => y.CategoryId == 5).Select(z => z.BlogId).FirstOrDefault();

            ViewBag.PostTitle = postTitle;
            ViewBag.PostImage = postImage;
            ViewBag.PostDate = postDate;
            ViewBag.PostId = postId;

            ViewBag.PostTitle2 = postTitle2;
            ViewBag.PostImage2 = postImage2;
            ViewBag.PostDate2 = postDate2;
            ViewBag.PostId2 = postId2;

            ViewBag.PostTitle3 = postTitle3;
            ViewBag.PostImage3 = postImage3;
            ViewBag.PostDate3 = postDate3;
            ViewBag.PostId3 = postId3;

            ViewBag.PostTitle4 = postTitle4;
            ViewBag.PostImage4 = postImage4;
            ViewBag.PostDate4 = postDate4;
            ViewBag.PostId4 = postId4;

            ViewBag.PostTitle5 = postTitle5;
            ViewBag.PostImage5 = postImage5;
            ViewBag.PostDate5= postDate5;
            ViewBag.PostId5 = postId5;

            return PartialView();
        }
        public PartialViewResult BlogPartial3()
        {
            return PartialView();
        }
        public ActionResult BlogDetail(int id)
        {
            ViewBag.BlogId = id;
            return View();
        }

        public PartialViewResult BlogDetailPartial(int id)
        {
            var value = _BlogManager.GetById(id);
            return PartialView(value);
        }
        public PartialViewResult AdminSocailMedia()
        {
            return PartialView();
        }
        public PartialViewResult BlogDetailPartial2(int id)
        {
            var value=_BlogManager.GetById(id);
            return PartialView(value);
        }
        public ActionResult BlogByCategory(int id)
        {
            var values = _BlogManager.GetPostByCaeogryId(id);
            var CategoryName = _BlogManager.GetList().Where(x => x.CategoryId == id).Select(y => y.Category.CategoryName).FirstOrDefault();
            var CategoryDesc = _BlogManager.GetList().Where(x => x.CategoryId == id).Select(y => y.Category.CategoryDescription).FirstOrDefault();

            ViewBag.CategoryName = CategoryName;
            ViewBag.CategoryDesc = CategoryDesc;
            return View(values);
        }

        [HttpGet]
        public ActionResult CommentDrop()
        {          
            return View();
        }

        [HttpPost]
        public ActionResult CommentDrop(Comment c)
        {
            c.CommentDate = DateTime.Now;
            c.CommentStatus = true;
            _commentManager.AddComment(c);
            return RedirectToAction("Index", "Blog");

        }

        [HttpGet]
        public ActionResult AddSubcribe()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSubcribe(Subscribe s)
        {
            _subscribeManager.AddSubscribe(s);
            return RedirectToAction("Index", "Blog");
        }
        public ActionResult AdminPanelBlog()
        {
            var values=_BlogManager.GetList();
            return View(values);
        }
        public ActionResult AdminPanelBlog2()
        {
            var values=_BlogManager.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddPost()
        {
            Context c = new Context() ;
            List<SelectListItem> values=(from x in c.Categories.ToList()select new SelectListItem
            {
                Text=x.CategoryName,
                Value=x.CategoryId.ToString(),
            }).ToList();

            List<SelectListItem> values2=(from x in c.Authors.ToList()select new SelectListItem
            {
                Text=x.AuthorName,
                Value=x.AuthorId.ToString(),
            }).ToList();
            ViewBag.v1 = values;
            ViewBag.v2 = values2;
            return View();
        }
        [HttpPost]
        public ActionResult AddPost(Blog b)
        {
            _BlogManager.BlogAdd(b);
            return RedirectToAction("AdminPanelBlog", "Blog");
        }
        public ActionResult DeletePost(int id)
        {
            _BlogManager.DeleteBlog(id);
            return RedirectToAction("AdminPanelBlog", "Blog");
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
            var value= _BlogManager.GetById2(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog b)
        {
            _BlogManager.BlogUpdate(b);
            return RedirectToAction("AdminPanelBlog", "Blog");
        }

        [HttpGet]
        public ActionResult GetBlogCommentByCommentId(int id)
        {
           var value= _commentManager.getById(id);
            return View(value);
        }
    }
}