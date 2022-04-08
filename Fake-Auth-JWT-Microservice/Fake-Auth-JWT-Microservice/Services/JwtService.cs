using Fake_Auth_JWT_Microservice.Helpers.Models;
using Fake_Auth_JWT_Microservice.Services.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Auth_JWT_Microservice.Services
{
    public class JwtService : IJwtService
    {
        private readonly JwtConfigs _jwtConfigs;
        public JwtService(IOptions<JwtConfigs> jwtConfigs)
        {
            _jwtConfigs = jwtConfigs.Value;
        }

        public string GenerateToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfigs.Secret);
            List<Claim> userClaims = new List<Claim>();
            userClaims.Add(new Claim("UserId", "0"));
            userClaims.Add(new Claim("UserName", "fakeuser@mail.com"));
            userClaims.Add(new Claim("Email", "fakeuser@mail.com"));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(userClaims),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
