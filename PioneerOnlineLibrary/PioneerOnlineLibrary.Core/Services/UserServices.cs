using PioneerOnlineLibrary.Core.Interface;
using PioneerOnlineLibrary.Domain.Model;
using PioneerOnlineLibrary.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Core.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetEmail(User email)
        {
          var user =  _userRepository.GetUserByEmail(email);
            
            return user;
        }

        public User GetUserName(User userName)
        {
            var user = _userRepository.GetUserByUserName(userName);
            
            return user;
        }
    }
}
