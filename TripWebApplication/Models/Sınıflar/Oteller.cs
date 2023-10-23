using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TripWebApplication.Models.Sınıflar
{
	public class Oteller
	{
		[Key]
		public int ID { get; set; }
		public string Baslik { get; set; }
		public string Aciklama { get; set; }
		public string PhotoUrl { get; set; }

	}
}