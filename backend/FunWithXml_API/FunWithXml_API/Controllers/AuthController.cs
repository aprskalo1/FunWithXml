using FunWithXml_API.Data;
using FunWithXml_API.Models;
using FunWithXml_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FunWithXml_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly FunWithXmlDbContext _context;

        public AuthController(IAuthService authService, FunWithXmlDbContext context)
        {
            _authService = authService;
            _context = context;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {
                var refreshToken = _authService.GenerateRefreshToken();
                var token = await _authService.LoginAsync(loginModel.Username, loginModel.Password, refreshToken);
                if (token != null)
                {
                    return Ok(new { token, refreshToken });
                }
                else
                {
                    return Unauthorized("Invalid username or password");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Split(" ")[1];
                await _authService.LogoutAsync(token);
                return Ok("Logged out successfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost]
        [Route("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] string refreshToken)
        {
            var user = await _context.LoginModel.FirstOrDefaultAsync(u => u.RefreshToken == refreshToken);

            if (user != null && user.RefreshTokenExpiryTime > DateTime.Now)
            {
                var newAccesToken = _authService.GenerateJwtTokenAsync(user.Username);
                var newRefreshToken = _authService.GenerateRefreshToken();
                
                user.RefreshToken = newRefreshToken;
                await _context.SaveChangesAsync();

                return Ok(new { newAccesToken, newRefreshToken });
            }

            return Unauthorized("Invalid refresh token");
        }
    }
}
