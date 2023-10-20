using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripWebApplication.Models.Sınıflar;

namespace TripWebApplication.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
		Context db = new Context();
		[Authorize]
        public ActionResult Index()
        {
			var BlogList = db.Blogs.ToList();
            return View(BlogList);
        }
		[HttpGet]
		public ActionResult YeniBlog()
		{
			return View();
		}
		[HttpPost]
		public ActionResult YeniBlog(Blog p)
		{
			db.Blogs.Add(p);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult BlogSil(int id)
		{
			var bS = db.Blogs.Find(id);
			db.Blogs.Remove(bS);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult BlogGetir(int id)
		{
			var bG = db.Blogs.Find(id);
			return View("BlogGetir", bG);
		}

		public ActionResult BlogGuncelle(Blog b)
		{
			var blg = db.Blogs.Find(b.ID);
			blg.Aciklama = b.Aciklama;
			blg.Baslik = b.Baslik;
			blg.BlogImage = b.BlogImage;
			blg.Tarih = b.Tarih;
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult YorumListesi()
		{
			var YorumList = db.Yorumlars.ToList();	
			return View(YorumList);
		}

		public ActionResult YorumSil(int id)
		{
			var ys = db.Yorumlars.Find(id);
			db.Yorumlars.Remove(ys);
			db.SaveChanges();
			return RedirectToAction("YorumListesi");
		}

		public ActionResult YorumGetir(int id)
		{
			var yg = db.Yorumlars.Find(id);
			return View("YorumGetir", yg);
		}

		public ActionResult YorumGuncelle(Yorumlar y)
		{
			var yrm = db.Yorumlars.Find(y.ID);
			yrm.KullaniciAdi = y.KullaniciAdi;
			yrm.Mail = y.Mail;
			yrm.Yorum = y.Yorum;
			db.SaveChanges();
			return RedirectToAction("YorumListesi");
		}

	}
}