using SchoolMGT.Api.Domain.clsEnums;
using SchoolMGT.Api.Domain.Models.clsStudent;
using SchoolMGT.Api.Domain.Models.clsTeacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Domain.Models.clsUser
{
    public class UserAccount
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long UserId { get; set; }
        //public Enums.UserRole Role { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}
