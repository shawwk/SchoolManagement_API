using AutoMapper;
using SchoolMGT.Api.Common;
using SchoolMGT.Api.Domain.Models.clsUser;
using SchoolMGT.Api.Helper;
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
        public async Task<UserAccountDTO> AddUser(UserAccount userAccount)
        {
            try
            {
                userAccount.Password = PasswordHelper.EncryptPassword(userAccount.Password);
                var user = await _userAccountRepository.AddUser(userAccount);
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<UserAccountDTO> AuthenticateUser(UserAccountDTO userAccount)
        {
            userAccount.Password = PasswordHelper.EncryptPassword(userAccount.Password);
            var account =  await _userAccountRepository.Authenticate(userAccount);
            if (account.UserName != "")
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
