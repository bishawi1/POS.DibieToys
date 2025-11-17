using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using POS.Shared.DTOs;
using POS.Shared.Models.Auth;
using POS.WebApi.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace POS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public AuthenticateController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            try
            {
                var userExists = await _userManager.FindByNameAsync(model.UserName);
                if (userExists != null)
                    return StatusCode(StatusCodes.Status500InternalServerError, new POS.Shared.Models.Auth.Response { Status = "Error", Message = "User already exist!" });
                ApplicationUser user = new()
                {
                    Email = model.Email,
                    SecurityStamp = new Guid().ToString(),
                    UserName = model.UserName,

                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (!result.Succeeded)
                {
                    var errors = new List<string>();

                    foreach (var error in result.Errors)
                    {
                        errors.Add(error.Description);
                    }
                    return StatusCode(StatusCodes.Status500InternalServerError, new POS.Shared.Models.Auth.Response { Status = "Error", Message = string.Join(", ", errors) });
                }
                return Ok(new POS.Shared.Models.Auth.Response { Status = "Success", Message = "user created successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new POS.Shared.Models.Auth.Response { Status = "Error", Message = ex.Message.ToString() });
            }

        }

        [HttpPost]
        [Route("Register-Admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            var userExists = _userManager.FindByNameAsync(model.UserName);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new POS.Shared.Models.Auth.Response { Status = "Error", Message = "User already exist!" });
            ApplicationUser user = new()
            {
                Email = model.Email,
                SecurityStamp = new Guid().ToString(),
                UserName = model.UserName,

            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                var errors = new List<string>();

                foreach (var error in result.Errors)
                {
                    errors.Add(error.Description);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, new POS.Shared.Models.Auth.Response { Status = "Error", Message = string.Join(", ", errors) });
            }
            if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

            if (!await _roleManager.RoleExistsAsync(UserRoles.User))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.User));

            if (await _roleManager.RoleExistsAsync(UserRoles.Admin))
                await _userManager.AddToRoleAsync(user, UserRoles.Admin);

            return Ok(new POS.Shared.Models.Auth.Response { Status = "Success", Message = "USer created successfully!" });
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            List<string> roleList = new List<string>();
            var user = await _userManager.FindByNameAsync(model.userName);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString())
                };
                foreach (var userRole in userRoles)
                {
                    roleList.Add(userRole);
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt:SecretKey"]));
                var token = new JwtSecurityToken(
                    issuer: _configuration["jwt:ValidIssuer"],
                    audience: _configuration["jwt:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );
                UserSession userSession = new UserSession
                {
                    ExpiresIn = (int)DateTime.Now.AddHours(3).Subtract(DateTime.Now).TotalSeconds,
                    ExpireTimeStamp = DateTime.Now.AddHours(3),
                    Role = roleList[0],
                    UserName = model.userName,
                    Token = new JwtSecurityTokenHandler().WriteToken(token)
                };
                return Ok(new ResultModel()
                {
                    Data = userSession,
                    StatusCode = "200",
                    ErrorText = null
                });
                //return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token), expiration = token.ValidTo,Roles = roleList });
            }
            return Ok(new ResultModel()
            {
                Data = null,
                StatusCode = "401",
                ErrorText = "Not Correct Login Name or Password"
            });
        }

        [HttpPost]
        [Route("Change-Password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
                return StatusCode(StatusCodes.Status404NotFound, new POS.Shared.Models.Auth.Response { Status = "Error", Message = "user does not exist!" });

            if (string.Compare(model.NewPassword, model.ConfirmNewPassword) != 0)
                return StatusCode(StatusCodes.Status400BadRequest, new POS.Shared.Models.Auth.Response { Status = "Error", Message = "The new password and confirm new password does not match!" });

            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            if (!result.Succeeded)
            {
                var errors = new List<string>();

                foreach (var error in result.Errors)
                {
                    errors.Add(error.Description);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, new POS.Shared.Models.Auth.Response { Status = "Error", Message = string.Join(", ", errors) });
            }
            return Ok(new POS.Shared.Models.Auth.Response { Status = "Success", Message = "Password Successfully changed." });
        }
        //Reset Password for Admin
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("Reset-Password-Admin")]
        public async Task<IActionResult> ResetPasswordAdmin([FromBody] ResetPasswordAdminModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
                return StatusCode(StatusCodes.Status404NotFound, new POS.Shared.Models.Auth.Response { Status = "Error", Message = "user does not exist!" });

            if (string.Compare(model.NewPassword, model.ConfirmNewPassword) != 0)
                return StatusCode(StatusCodes.Status400BadRequest, new POS.Shared.Models.Auth.Response { Status = "Error", Message = "The new password and confirm new password does not match!" });

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);
            if (!result.Succeeded)
            {
                var errors = new List<string>();

                foreach (var error in result.Errors)
                {
                    errors.Add(error.Description);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, new POS.Shared.Models.Auth.Response { Status = "Error", Message = string.Join(", ", errors) });
            }

            return Ok(new POS.Shared.Models.Auth.Response { Status = "Success", Message = "Password Successfully Reset." });
        }

        //reset password for user
        [HttpPost]
        [Route("Reset-Password-Token")]
        public async Task<IActionResult> ResetPasswordToken([FromBody] ResetPasswordTokenModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
                return StatusCode(StatusCodes.Status404NotFound, new POS.Shared.Models.Auth.Response { Status = "Error", Message = "user does not exist!" });

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            return Ok(new { token = token });
        }

        [HttpPost]
        [Route("Reset-Password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
                return StatusCode(StatusCodes.Status404NotFound, new POS.Shared.Models.Auth.Response { Status = "Error", Message = "user does not exist!" });

            if (string.Compare(model.NewPassword, model.ConfirmNewPassword) != 0)
                return StatusCode(StatusCodes.Status400BadRequest, new POS.Shared.Models.Auth.Response { Status = "Error", Message = "The new password and confirm new password does not match!" });

            if (string.IsNullOrEmpty(model.Token))
                return StatusCode(StatusCodes.Status400BadRequest, new POS.Shared.Models.Auth.Response { Status = "Error", Message = "Invalid Token!" });

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
            if (!result.Succeeded)
            {
                var errors = new List<string>();

                foreach (var error in result.Errors)
                {
                    errors.Add(error.Description);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, new POS.Shared.Models.Auth.Response { Status = "Error", Message = string.Join(", ", errors) });
            }

            return Ok(new POS.Shared.Models.Auth.Response { Status = "Success", Message = "Password Successfully Reset." });
        }
    }

}
