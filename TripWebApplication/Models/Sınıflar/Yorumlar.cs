﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TripWebApplication.Models.Sınıflar
{
	public class Yorumlar
	{
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public DateTime Tarih { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
    }
}