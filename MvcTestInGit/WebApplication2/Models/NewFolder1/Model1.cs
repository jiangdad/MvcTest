namespace WebApplication2.Models.NewFolder1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Directors> Directors { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Directors>()
                .HasMany(e => e.Movies)
                .WithOptional(e => e.Directors)
                .HasForeignKey(e => e.Director_ID);
        }
    }
}
