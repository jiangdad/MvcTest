using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication4.Models
{
    public class SampleData:DropCreateDatabaseIfModelChanges<UserDiaryDb>
    {
        protected override void Seed(UserDiaryDb userDiaryDb)
        {
            userDiaryDb.user.Add(new User
            {
                UserName = "jiang",
                Password = "jiang",
                diaries = new List<Diary>
                 {
                     new Diary{ Title="title1", Content="content1", PubDate=DateTime.Now},
                     new Diary{ Title="title2", Content="content2", PubDate=DateTime.Now},
                     new Diary{ Title="title3", Content="content3", PubDate=DateTime.Now}
                 }
            });
            userDiaryDb.user.Add(new User
            {
                UserName = "liu",
                Password = "liu",
                diaries = new List<Diary>
                 {
                     new Diary{ Title="title4", Content="content4", PubDate=DateTime.Now},
                     new Diary{ Title="title5", Content="content5", PubDate=DateTime.Now},
                     new Diary{ Title="title6", Content="content6", PubDate=DateTime.Now}
                 }
            });
            base.Seed(userDiaryDb);
        }
    }
}