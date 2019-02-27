using DIary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Service.User
{
    public class UserManager:IUserManager
    {
        private IUserRepository _UserRepository;
        //private IUserService _UserService;
        public UserManager(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }
        public IUserService Add(DIary.Data.Users user)
        {
            //user.createTime = DateTime.Now;
            var md5 = new Tgnet.Security.MD5();
            user.Password = md5.Encrypt(user.Password);
            _UserRepository.Add(user);
            _UserRepository.SaveChanges();
            IUserService _UserService = new UserService(_UserRepository, user.Id);
            return _UserService;
        }
        //核查用户姓名是否存在
        public bool CheckUserName(string userName)
        {
            return !_UserRepository.Entities.Any(l => l.UserName == userName);
        }
        //用户登录
        public UserLoginModel Login(DIary.Data.Users user)
        {
            UserLoginModel model = new UserLoginModel();
            var md5 = new Tgnet.Security.MD5();
            user.Password = md5.Encrypt(user.Password);
            var userEntity = _UserRepository.Entities.Where(u => u.UserName == user.UserName && u.Password == user.Password/* && !u.isDel*/).FirstOrDefault();
            if (userEntity == null)
            {
                model.Status = "error";
                model.Msg = "对不起，用户名与密码不正确";
                return model;
            }
            model.Status = "ok";
            model.Msg = "登陆成功";
            model.UserId = userEntity.Id;
            model.UserName = userEntity.UserName;
            _UserRepository.Update(u => u.Id == userEntity.Id, l => new DIary.Data.Users() { landIp = user.landIp, lastLandTime = user.lastLandTime });
            return model;
        }
        IUserService IUserManager.GetService(int userId)
        {
            IUserService _UserService = new UserService(_UserRepository, userId);
            return _UserService;
        }
    }
}
