using AuthProject.Api.DBContext;
using AuthProject.Api.helpers;
using AuthProject.Api.Models.DTOs;
using AuthProject.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController(AgendaDB _db, TokenService _tokenService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(CreateUserDTO data)
        {
            try
            {
                var user = _db.Users.Where(u => u.UserName == data.Username).FirstOrDefault();
                if (user == null) return Unauthorized();

                if (!EncryptHelper.VerifyPassword(data.Password, user.PasswordHash))
                    return Unauthorized();

                return Ok(new
                {
                    token = _tokenService.GenerateToken(user.UserName)
                });
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return Unauthorized();
            }
        }

        [HttpPost("refreshToken")]
        public IActionResult RefreshToken([FromBody]string token)
        {
            var userName = _tokenService.ValidateToken(token);
            if(userName == null)
            {
                return Unauthorized("Invalid token.");
            }

            return Ok(new
            {
                token = _tokenService.GenerateToken(userName)
            });
        }
    }
}
