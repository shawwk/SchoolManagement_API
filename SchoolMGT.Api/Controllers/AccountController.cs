using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMGT.Api.Domain.Models.clsUser;
using SchoolMGT.Api.Service.UserAcountServices;

namespace SchoolMGT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserAccountService _userAccountService;
        public AccountController(IUserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }

        [HttpPost]
        [Route("Authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]UserAccountDTO userAccount) 
        {
            var _account = await _userAccountService.AuthenticateUser(userAccount);
            if (_account.UserName == "") { 
                return NotFound("Username not found: " + userAccount.UserName);
            }
            return Ok(_account.Token);
        }
    }
}
