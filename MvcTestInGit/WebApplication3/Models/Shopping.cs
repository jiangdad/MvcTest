using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ;
namespace WebApplication3.Models
{
    public class Shopping:DbContext
    {
        public System.Data.Entity.DbSet<UserModel> UserModel = new DbSet<UserModel>();
    }
}