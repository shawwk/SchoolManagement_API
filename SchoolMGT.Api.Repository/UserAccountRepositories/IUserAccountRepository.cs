using SchoolMGT.Api.Domain.Models.clsUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Repository.UserAccountRepositories
{
    public interface IUserAccountRepository
    {
        Task<UserAccountDTO> AddUser(UserAccount userAccount);
        Task<UserAccount> UpdateUser(UserAccount userAccount);
        Task<UserAccountDTO> Authenticate(UserAccountDTO userAccount);
    }
}
