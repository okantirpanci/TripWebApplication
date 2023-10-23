using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TripWebApplication.Models.Sınıflar
{
	public class Context : DbContext
	{
		public DbSet<Admin> Admins { get; set; }
		public DbSet<AdresBlog> AdresBlogs { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Hakkimizda> Hakkimizdas { get; set; }
		public DbSet<İletisim> Iletisims { get; set; }
		public DbSet<Yorumlar> Yorumlars { get; set; }
		public DbSet<Oteller> Otellers { get; set; }
		public DbSet<Restorantlar> Restorantlars { get; set; }
		public DbSet<Muzeler> Muzelers { get; set; }
	}
}