using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripWebApplication.Models.Sınıflar;

namespace TripWebApplication.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context Db = new Context();
        BlogPage BlogPage = new BlogPage();
        public ActionResult Blog()
        {
            BlogPage.BlogList = Db.Blogs.ToList();
            BlogPage.LastBlogs = Db.Blogs.OrderByDescending(b => b.Tarih).Take(3).ToList();
            BlogPage.LastYorumlars = Db.Yorumlars.OrderByDescending(b => b.Tarih).Take(2).ToList();
            return View(BlogPage);
        }

		public ActionResult BlogDetail(int id)
		{
            
            BlogPage.BlogList = Db.Blogs.Where(x => x.ID == id).ToList();
			BlogPage.LastBlogs = Db.Blogs.OrderByDescending(b => b.Tarih).Take(3).ToList();
			BlogPage.YorumList = Db.Yorumlars.Where(x => x.Blogid == id).ToList();
			BlogPage.LastYorumlars = Db.Yorumlars.OrderByDescending(b => b.Tarih).Take(2).ToList();
			return View(BlogPage);
		}
        [HttpGet]
		public PartialViewResult YorumYap(int id)
		{
			ViewBag.deger = id;
			return PartialView();
		}

		[HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
			Db.Yorumlars.Add(y);
			Db.SaveChanges();
			return PartialView();
		}
	}
}