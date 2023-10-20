using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripWebApplication.Models.Sınıflar
{
	public class BlogPage
	{
       public IEnumerable<Blog> BlogList { get; set; } 
       public IEnumerable<Blog> LastBlogs { get; set; }
       public IEnumerable<Yorumlar> LastYorumlars { get; set; }
       public IEnumerable<Yorumlar> YorumList { get; set; }
    }
}