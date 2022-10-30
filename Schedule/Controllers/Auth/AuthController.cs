using ApplicationCore.Domain.Entities;
using AutoMapper;
using Command.Auth.Login;
using Command.Auth.Registration;
using Command.Users.CreateNewUser;
using FitnessWeb.API.Identity;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TYPO.ApplicationCore.Domain.Entities;
using TYPO.Identity;

namespace TYPO.Controllers.Auth
{

    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AuthController(IMapper mapper, IMediator mediator, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _mapper = mapper;
            _mediator = mediator;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [AllowAnonymous]
        [HttpPost("registration")]
        public async Task<IActionResult> RegisterUser([FromBody] RegistrationCommand command)
        {
            if (command == null || !ModelState.IsValid) return BadRequest();
            var result = await _mediator.Send(command);
            if (result == -1) return BadRequest("An error occured...");
            return Ok(result);
        }


        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand command)
        {
            var user = await _userManager.FindByNameAsync(command.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user, command.Password))
                return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });

            if (user != null && user.IsAdmin)
            {
                var adminCredentials = new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256);
                var jwtAdminSecurityToken = new JwtSecurityToken(
                     issuer: AuthOptions.ISSUER,
                     audience: AuthOptions.AUDIENCE,
                     claims: new List<Claim>()
                     {
                     new Claim("username", user.Email),
                     new Claim("id", user.Id.ToString()),
                     new Claim("isAdmin", "true")
                     },
                     expires: DateTime.Now.AddDays(30),
                     signingCredentials: adminCredentials
                );
                var tokenAdminHandler = new JwtSecurityTokenHandler();

                var encodedAdminToken = tokenAdminHandler.WriteToken(jwtAdminSecurityToken);
                return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = encodedAdminToken });
            }
            var signinCredentials = new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256);
            var jwtSecurityToken = new JwtSecurityToken(
                 issuer: AuthOptions.ISSUER,
                 audience: AuthOptions.AUDIENCE,
                 claims: new List<Claim>()
                 {
                     new Claim("username", user.Email),
                     new Claim("id", user.Id.ToString()),
                     new Claim("isAdmin", "false")
                 },
                 expires: DateTime.Now.AddDays(30),
                 signingCredentials: signinCredentials
            );
            var tokenHandler = new JwtSecurityTokenHandler();

            var encodedToken = tokenHandler.WriteToken(jwtSecurityToken);
            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = encodedToken });
        }

        [HttpPost]
        [Route("logout")]
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
    }
}









/*
 if (command == null || !ModelState.IsValid)
    return BadRequest();

User user = new User
{
    IsAdmin = command.IsAdmin,
    Email = command.Email,
    FirstName = command.FirstName,
    LastName = command.LastName,
    Password = command.Password,
    Age = command.Age,
    Gender = command.Gender,
    CreatedAt = DateTimeOffset.Now,
    CreatedBy = command.Email,
    UserName = command.Email,
    UserInfo = new()
    {
        ThemeColors = "",
        Language = "English",
        SignUpAt = DateTime.Now,
        CreatedBy = command.Email,
        CreatedAt = DateTime.Now,
    },
    StatisticsAVG = new()
    {
        AvgSymbolsPerMin = 0,
        AvgAccuracy = 0,
        AvgTime = "00:00",
        CreatedBy = command.Email,
        CreatedAt = DateTime.Now,
    },
    Images = new List<Image>()
    {
        new Image { ImageTitle = "https://thumbs.dreamstime.com/b/default-avatar-profile-trendy-style-social-media-user-icon-187599373.jpg", CreatedBy = "D", CreatedAt = DateTimeOffset.Now}
    }
};

var result = await _userManager.CreateAsync(user, command.Password);

if (!result.Succeeded)
{
    var errors = result.Errors.Select(e => e.Description);

    return BadRequest(new RegistrationResponseDto { Errors = errors });
}

return StatusCode(201);
 */