using AutoMapper;
using SchoolMGT.Api.Common;
using SchoolMGT.Api.Domain.Models.clsUser;
using SchoolMGT.Api.Repository.UserAccountRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Service.UserAcountServices
{
    public class UserAccountService : IUserAccountService
    {
        private readonly IUserAccountRepository _userAccountRepository;
        private readonly IMapper _mapper;
        public UserAccountService(IUserAccountRepository userAccountRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userAccountRepository = userAccountRepository;
        }
        public Task<UserAccountDTO> AddUser(UserAccountDTO userAccount)
        {
            throw new NotImplementedException();
        }

        public async Task<UserAccountDTO> AuthenticateUser(UserAccountDTO userAccount)
        {
            var account =  await _userAccountRepository.Authenticate(userAccount);
            if (account != null)
            {
                account.Token = JwtManager.GenerateToken(_mapper.Map<UserAccount>(account));
                return account;
            }
            return account;
        }

        public Task<UserAccountDTO> UpdateUser(UserAccountDTO userAccount)
        {
            throw new NotImplementedException();
        }
    }
}
