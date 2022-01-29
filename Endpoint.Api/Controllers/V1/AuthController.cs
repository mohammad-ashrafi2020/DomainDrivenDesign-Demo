using Clean_arch.Application.Users.Register;
using Clean_arch.Query.Users.GetByEmail;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Endpoint.Api.Controllers.V1
{
    [ApiVersion("1.0", Deprecated = true)]
    [Route("v{version:apiVersion}/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;

        public AuthController(IMediator mediator, IConfiguration configuration)
        {
            _mediator = mediator;
            _configuration = configuration;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = await _mediator.Send(new GetUserByEmailQuery(email));
            if (user == null)
                return NotFound("کاربری با مشخصات وارد شده یافت نشد");

            if (user.Phone != password)
                return NotFound("کاربری با مشخصات وارد شده یافت نشد");

            var claims = new List<Claim>()
            {
                new Claim("email",user.Email),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            };
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtConfig:SignInKey"]));
            var credential = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtConfig:Issuer"],
                audience: _configuration["JwtConfig:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: credential);

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(jwtToken);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser(RegisterUserCommand command)
        {
            var result = await _mediator.Send(command);
            return Created("", result);
        }
    }
}