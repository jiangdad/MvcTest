using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace WebApplication4.Models.Test
{
    public class DiaryContext:DbContext
    {
        public DiaryContext()
            : base("name=DiaryEntities")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<DiaryUser> DiaryUser { get; set; }
    }
}