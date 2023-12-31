﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TripWebApplication.Models.Sınıflar;

namespace TripWebApplication.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context db = new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = db.Admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici,false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else { return View(); }
        }
		public ActionResult LogOut()
		{
			FormsAuthentication.SignOut();
            return RedirectToAction("Login","GirisYap");
		}

	}
}