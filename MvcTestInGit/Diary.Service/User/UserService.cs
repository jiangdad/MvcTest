using DIary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tgnet;
using Tgnet.Api;

namespace Diary.Service.User
{
    public class UserService:IUserService
    {
        private IUserRepository _UserRepository;
        private Lazy<DIary.Data.Users> _LazyUser;
        private readonly int _UserId;

        int IUserService.UserId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        string IUserService.UserName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        DateTime IUserService.LastLandTime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        string IUserService.LandIp
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IUserService.IsDel
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public UserService(IUserRepository userRepository, int uid)
        {
            ExceptionHelper.ThrowIfNotId(uid, "uid");
            _UserId = uid;
            _UserRepository = userRepository;
            _LazyUser = new Lazy<DIary.Data.Users>(() =>
            {
                var user = _UserRepository.Entities.FirstOrDefault(u => u.Id == uid);
                if (user == null)
                    throw new ExceptionWithErrorCode(ErrorCode.没有找到对应条目, "用户不存在");
                return user;
            });

        }

        void IUserService.UpdatePassWord(string passWord)
        {
            throw new NotImplementedException();
        }

        void IUserService.Delete()
        {
            throw new NotImplementedException();
        }
    }
}