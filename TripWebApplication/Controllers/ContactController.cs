using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripWebApplication.Models.Sınıflar;

namespace TripWebApplication.Controllers
{
    public class ContactController : Controller
    {
		// GET: İletisim
		Context Db = new Context();
		public ActionResult Contact()
        {
            return View();
        }

		[HttpGet]
		public PartialViewResult Mesaj()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult Mesaj(İletisim i)
		{
			Db.Iletisims.Add(i);
			Db.SaveChanges();
			return PartialView();
		}
	}
}