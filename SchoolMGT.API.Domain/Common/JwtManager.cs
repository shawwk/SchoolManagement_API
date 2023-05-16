using Microsoft.IdentityModel.Tokens;
using SchoolMGT.Api.Domain.Models.clsUser;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SchoolMGT.Api.Common
{
    public static class JwtManager
    {
        private static readonly string secretKey = "RCWIWJUH81aqxasd112312441XXASdaASDASD";
        private static readonly string issuer = "http://localhost:38458";
        private static readonly string audience = "http://localhost:38458";
        private static readonly SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        public static string GenerateToken(UserAccount userAccount)
        {
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userAccount.UserName)
            };
            var token = new JwtSecurityToken(issuer, audience, claims, expires: DateTime.Now.AddMinutes(15), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public static bool ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = issuer,
                    ValidAudience = audience,
                    IssuerSigningKey = securityKey
                }, out SecurityToken validatedToken);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
