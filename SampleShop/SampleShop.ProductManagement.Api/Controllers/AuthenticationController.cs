using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SampleShop.ProductManagement.Models.DatabaseContext;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SampleShop.ProductManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;

        private List<User> appUsers = new List<User> {
            new User {
                FullName = "Nassia Oiko",
                UserName = "admin",
                Password = "1234",
                UserRole = "Admin" },
            new User {
                FullName = "Test User",
                UserName = "user",
                Password = "1234",
                UserRole = "User" }
        };
        public AuthenticationController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] User login)
        {
            User user = AuthenticateUser(login);
            if (user != null)
            {
                var tokenString = GenerateJwtToken(user);
                return Ok(new { token = tokenString, userDetails = user });
            }

            return Unauthorized();
        }

        private User AuthenticateUser(User credentials)
        {
            User user = appUsers.SingleOrDefault(x => x.UserName == credentials.UserName && x.Password == credentials.Password);
            return user;
        }

        private string GenerateJwtToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserName),
                new Claim("fullName", userInfo.FullName.ToString()),
                new Claim("role", userInfo.UserRole),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), };

            var token = new JwtSecurityToken(issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
