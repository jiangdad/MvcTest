using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DIary.Data
{
    public interface IUserRepository: Tgnet.Data.IRepository<Users>
    {

    }
    public class UserRepository: Tgnet.Data.Entity.EFRepository<UserDiaryEntities, Users>, IUserRepository
    {
        private UserDiaryEntities _dbContext;

        public UserRepository(UserDiaryEntities context) : base(context)
        {
            _dbContext = context;
        }

        protected override DbSet<Users> DbSet
        {
            get
            {
                return _dbContext.Set<Users>();
            }
        }
    }
}