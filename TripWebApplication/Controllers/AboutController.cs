using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripWebApplication.Models.Sınıflar;

namespace TripWebApplication.Controllers
{
    public class AboutController : Controller
    {
		// GET: About
		
        Context Db = new Context();
		public ActionResult Index()
        {
            var deger = Db.Hakkimizdas.ToList();
            return View(deger);
        }
    }
}