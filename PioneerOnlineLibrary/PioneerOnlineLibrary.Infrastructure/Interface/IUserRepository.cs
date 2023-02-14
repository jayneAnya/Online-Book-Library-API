using PioneerOnlineLibrary.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Infrastructure.Interface
{
    public interface IUserRepository
    {
        User CreateUser (User user);
        User GetUserByEmail(User email);
        User GetUserByUserName(User userName);
    }
}
