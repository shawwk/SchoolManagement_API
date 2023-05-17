using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Domain.Models.clsUser
{
    public class UserAccountDTO
    {
        public UserAccountDTO()
        {
            UserName = "";
            Password = "";
            Token = "";
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
