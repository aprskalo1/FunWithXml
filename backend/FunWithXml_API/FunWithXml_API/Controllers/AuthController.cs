﻿using FunWithXml_API.Models;
using FunWithXml_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FunWithXml_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {
                var token = await _authService.LoginAsync(loginModel.Username, loginModel.Password);
                if (token != null)
                {
                    return Ok(new { token });
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
        [Authorize]
        public IActionResult Logout()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Split(" ")[1];
                _authService.LogoutAsync(token);
                return Ok("Logged out successfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
