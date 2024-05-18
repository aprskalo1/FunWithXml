using FunWithXml_API.Data;
using FunWithXml_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace FunWithXml_API.Services
{
    public interface IAuthService
    {
        string GenerateJwtTokenAsync(string username);
        Task<string> LoginAsync(string username, string password, string refreshToken);
        Task LogoutAsync(string token);
        Task<bool> IsTokenBlackListedAsync(string token);
        string GenerateRefreshToken();

        public class AuthService : IAuthService
        {
            private readonly FunWithXmlDbContext _context;

            public AuthService(FunWithXmlDbContext context)
            {
                _context = context;
            }

            public string GenerateJwtTokenAsync(string username)
            {
                var tokenKey = Encoding.UTF8.GetBytes("C4aFJ0hlUIHvFPrIjyfWzjQoq4RiW/2s7/0B/tzMx5o=");

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }),
                    Expires = DateTime.UtcNow.AddMinutes(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);

                return tokenHandler.WriteToken(token);
            }

            public async Task<string> LoginAsync(string username, string password, string refreshToken)
            {
                var user = await _context.LoginModel.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    user.RefreshToken = refreshToken;
                    user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
                    await _context.SaveChangesAsync();

                    return GenerateJwtTokenAsync(username);
                }

                return null;
            }

            public async Task LogoutAsync(string token)
            {
                await _context.BlackListedTokens.AddAsync(new BlackListedTokens { Token = token });
                await _context.SaveChangesAsync();
            }


            public Task<bool> IsTokenBlackListedAsync(string token)
            {
                return _context.BlackListedTokens.AnyAsync(t => t.Token == token);
            }

            public string GenerateRefreshToken()
            {
                var randomNumber = new byte[32];
                using var rng = RandomNumberGenerator.Create();
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
    }
}
