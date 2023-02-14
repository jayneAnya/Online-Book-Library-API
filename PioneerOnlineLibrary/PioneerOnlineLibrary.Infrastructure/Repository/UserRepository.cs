using Microsoft.EntityFrameworkCore;
using PioneerOnlineLibrary.Domain.Enum;
using PioneerOnlineLibrary.Domain.Model;
using PioneerOnlineLibrary.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly PioneerDbContext _context;
        public UserRepository(PioneerDbContext pioneerDbContext)
        {
            _context = pioneerDbContext;
        }
        public User CreateUser(User user)
        {
            var newUser = new User
            {
                UserId = user.UserId,
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                Phone = user.Phone,
                Role = user.Role,
                FirstName = user.FirstName,
                LastName = user.LastName,
            };
            _context.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public User GetUserByEmail(User email)
        {
            _context.Users.FirstOrDefault(x => x.Email.Equals(email));
            if (email == null)
            {
                throw new Exception("Not Found");
            }
            return email;
        }


        public User GetUserByUserName(User userName)
        {
            _context.Users.FirstOrDefault(x => x.UserName.Equals(userName));
            if(userName == null)
            {
                throw new Exception("Not Found");
            }
            return userName;
        }

        //public User Login(User user)
        //{
        //    var newUser = new User
        //    {
        //        UserName = user.UserName,
        //        Password = user.Password,
        //    };

        //    _context.Add(newUser);
        //    _context.SaveChanges();
        //    return newUser;
        //}
    }

   
}

 