using SchoolMGT.Api.Domain.Models.clsUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Service.UserAcountServices
{
    public interface IUserAccountService
    {
        Task<UserAccountDTO> AddUser(UserAccountDTO userAccount);
        Task<UserAccountDTO> UpdateUser(UserAccountDTO userAccount);
        Task<UserAccountDTO> AuthenticateUser(UserAccountDTO userAccount);
    }
}
