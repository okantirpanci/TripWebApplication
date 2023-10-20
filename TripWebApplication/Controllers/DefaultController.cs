using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripWebApplication.Models.Sınıflar;

namespace TripWebApplication.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context Db = new Context();
        public ActionResult Index()
        {
            var slider = Db.Blogs.Take(8).ToList();
            return View(slider);
        }

        public PartialViewResult Partial1()
        {
            var TwoBlog = Db.Blogs.OrderByDescending(b => b.ID >= 3).Take(2).ToList();
            return PartialView(TwoBlog);
        }
        public PartialViewResult Partial2()
        {
            var OneBlog = Db.Blogs.OrderByDescending(b => b.Tarih).Take(1).ToList();
            return PartialView(OneBlog);
        }
        public PartialViewResult Partial3()
        {
            var LastTenBlog = Db.Blogs.OrderByDescending(b => b.Tarih).Take(10).ToList();
            return PartialView(LastTenBlog);
        }
        public PartialViewResult Partial4()
        {
            var LastTreeBlogLeft = Db.Blogs.OrderBy(b => b.Tarih).Take(3).ToList();
            return PartialView(LastTreeBlogLeft);
        }
        public PartialViewResult Partial5()
        {
            var LastTreeBlogRight = Db.Blogs.OrderByDescending(b => b.Tarih).Take(3).ToList();
            return PartialView(LastTreeBlogRight);
        }
    }
}