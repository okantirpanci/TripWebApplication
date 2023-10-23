using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripWebApplication.Models.Sınıflar;

namespace TripWebApplication.Controllers
{
    public class RehberController : Controller
    {
        // GET: Rehber
        Context db = new Context();
        RehberPage RehberPage = new RehberPage();
        public ActionResult Index()
        {
            RehberPage.OtelList = db.Otellers.ToList();
            RehberPage.RestorantList = db.Restorantlars.ToList();
            RehberPage.MuzelerList = db.Muzelers.ToList();
            return View(RehberPage);
        }
	}
}