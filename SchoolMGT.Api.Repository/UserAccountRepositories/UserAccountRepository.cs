using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SchoolMGT.Api.Domain.Models.clsUser;
using SchoolMGT.Api.Repository.Data;
using SchoolMGT.Api.Repository.UserAccountRepositories;
using SchoolMGT.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SchoolMGT.Api.Common;
using SchoolMGT.Api.Helper;

namespace SchoolMGT.Api.Repository.UserAccountRepository
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly RepositoryDbContext _context;
        private readonly IMapper _mapper;
        public UserAccountRepository(RepositoryDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UserAccountDTO> AddUser(UserAccount userAccount)
        {
            try
            {
                await _context.UserAccounts.AddAsync(userAccount);
                await _context.SaveChangesAsync();
                return _mapper.Map<UserAccountDTO>(userAccount);
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating user account: " + ex.Message);
            }
        }

        public async Task<UserAccountDTO> Authenticate(UserAccountDTO userAccount)
        {
            try
            {
                var user = await _context.UserAccounts.SingleOrDefaultAsync(x => x.UserName == userAccount.UserName 
                && x.Password == userAccount.Password);
                if (user == null)
                    return new UserAccountDTO();
                else
                    return _mapper.Map<UserAccountDTO>(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Error authenticating user acount: " + ex.Message);
            }
         
        }

        public Task<UserAccount> UpdateUser(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }
    }
}
