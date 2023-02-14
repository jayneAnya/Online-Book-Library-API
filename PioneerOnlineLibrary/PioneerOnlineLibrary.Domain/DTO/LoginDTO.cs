using PioneerOnlineLibrary.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Domain.DTO
{
    public  class LoginDTO
    {
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;

        public Role Role { get; set; }
    }
}
