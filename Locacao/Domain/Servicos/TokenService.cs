using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Locacao.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Locacao.Domain.Servicos
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration configuration;
        public TokenService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GerarToken(string login, string role)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(configuration.GetValue<string>("jAppSettings:JwtToken"));
            var expirationTime = configuration.GetValue<int>("jAppSettings:ExpirationTime");
			
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]{
                        new Claim(ClaimTypes.Name, login),
                        new Claim(ClaimTypes.Role, role.ToString()),
                    }),
                Expires = DateTime.UtcNow.AddHours(expirationTime),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}