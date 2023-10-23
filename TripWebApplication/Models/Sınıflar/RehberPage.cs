using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripWebApplication.Models.Sınıflar
{
	public class RehberPage
	{
		public IEnumerable<Oteller> OtelList { get; set; }
		public IEnumerable<Restorantlar> RestorantList { get; set; }
		public IEnumerable<Muzeler> MuzelerList { get; set; }
	}
}