using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication4.Models
{
    public class UserDiaryDb:DbContext
    {

        public UserDiaryDb()
            : base("WebApplication4.Models.UserDiaryDb")
        {
        }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Diary> DiaryUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<User>().ToTable("User_test");
            //modelBuilder.Entity<Diary>().ToTable("Diary_test");
        }
    }
}