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

        public ActionResult OtelDetails(int id)
        {
            var OtelList = db.Otellers.Where(x => x.ID == id).ToList();
            return View(OtelList);  
        } 
        public ActionResult RestorantDetails(int id)
        {
            var RestorantList = db.Restorantlars.Where(x => x.ID == id).ToList();
            return View(RestorantList);  
        }
        public ActionResult MuzeDetails(int id)
        {
            var MuzelerList = db.Muzelers.Where(x => x.ID == id).ToList();
            return View(MuzelerList);  
        }
	}
}