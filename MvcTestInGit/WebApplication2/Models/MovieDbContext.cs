using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MovieDbContext:DbContext
    {
        

        public System.Data.Entity.DbSet<Movie> Movies { get; set; }
        public System.Data.Entity.DbSet<Director> Director { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>()
                .HasMany(e => e.Movie)
                .WithOptional(e => e.Director);
        }
    }
}