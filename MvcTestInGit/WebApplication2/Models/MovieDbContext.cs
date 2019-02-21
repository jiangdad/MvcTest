using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MovieDbContext:DbContext
    {
        

        public System.Data.Entity.DbSet<WebApplication2.Models.Movie> Movies { get; set; }
        public System.Data.Entity.DbSet<WebApplication2.Models.Director> Director { get; set; }

    }
}