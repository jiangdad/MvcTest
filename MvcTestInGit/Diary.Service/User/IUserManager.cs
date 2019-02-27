using DIary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Service.User
{
    public interface IUserManager
    {
         IUserService Add(DIary.Data.Users user);

        UserLoginModel Login(DIary.Data.Users user);

        IUserService GetService(int userId);

        //bool CheckEmail(string email);

        bool CheckUserName(string userName);
    }
}
