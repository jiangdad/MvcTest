using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Service.User
{
    public  interface IUserService
    {
        int UserId { get; }
        string UserName { get; }

        DateTime LastLandTime { get; }

        string LandIp { get; }

        bool IsDel { get; }

        void UpdatePassWord(string passWord);

        void Delete();
    }
}
