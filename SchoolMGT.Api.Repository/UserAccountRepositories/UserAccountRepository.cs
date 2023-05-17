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
        public Task<UserAccountDTO> AddUser(UserAccountDTO userAccount)
        {
            throw new NotImplementedException();
        }

        public async Task<UserAccountDTO> Authenticate(UserAccountDTO userAccount)
        {
            var user = await _context.UserAccounts.SingleOrDefaultAsync(x=>x.UserName == userAccount.UserName && x.Password == userAccount.Password);
            if (user == null)
                return new UserAccountDTO() ;
            else 
                return _mapper.Map<UserAccountDTO>(user);
        }

        public Task<UserAccount> UpdateUser(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }
    }
}
