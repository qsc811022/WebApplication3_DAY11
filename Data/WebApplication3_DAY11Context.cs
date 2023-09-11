using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3_DAY11.Data
{
    public class WebApplication3_DAY11Context : DbContext
    {
        public WebApplication3_DAY11Context() : base("name=WebApplication3_DAY11Context")
        {
        }

		public System.Data.Entity.DbSet<WebApplication3_DAY11.Models.Student> Students { get; set; }
	}
}
