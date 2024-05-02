using FunWithXml_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FunWithXml_API.Services
{
    public interface IAuthService
    {
        string GenerateJwtTokenAsync(string username);
        Task<string> LoginAsync(string username, string password);
    }

    public class AuthService : IAuthService
    {
        private readonly FunWithXmlDbContext _context;

        public AuthService(FunWithXmlDbContext context)
        {
            _context = context;
        }

        public string GenerateJwtTokenAsync(string username)
        {
            var tokenKey = Encoding.UTF8.GetBytes("superSecretKey@345");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public async Task<string> LoginAsync(string username, string password)
        {
            var user = await _context.LoginModel.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                return GenerateJwtTokenAsync(username);
            }

            return null;
        }
    }
}
