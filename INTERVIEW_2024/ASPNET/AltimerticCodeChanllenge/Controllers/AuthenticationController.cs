using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using AltimerticCodeChanllenge.DTO;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Linq;

namespace AltimerticCodeChanllenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> logger;
        private readonly JWTOptions? jwtOptions;
        private readonly IConfiguration config;

        public AuthController(ILogger<AuthController> logger, IOptions<JWTOptions> jwtOptions, IConfiguration config)
        {
            this.logger = logger;
            this.jwtOptions = jwtOptions.Value;
            this.config = config;
        }

        [HttpPost]
        public IActionResult GenerateToken(User user)
        {
            logger.LogInformation("Enter : GenerateToken()");
            if (user != null && !String.IsNullOrEmpty(user.UserName) && !String.IsNullOrEmpty(user.Password))
            {
                if (user.UserName == config["User:UserName"]?.ToString() &&
                    user.Password == config["User:Password"]?.ToString())
                {

                    var claims =new ClaimsIdentity( new[] {
                                            new Claim(JwtRegisteredClaimNames.Sub, user.UserName)
                                            //,new Claim(JwtRegisteredClaimNames.Email, user.Email)

                                        });


                    var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions?.Key!));
                    var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

                    var tokenDescriptor = new SecurityTokenDescriptor {
                        Subject = claims,
                        Issuer = jwtOptions?.Issuer,
                        Audience= jwtOptions?.Audience,
                        Expires= DateTime.UtcNow.AddMinutes(jwtOptions!.DurationInMinutes),
                        SigningCredentials= signingCredentials
                        };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var jwtToken = tokenHandler.WriteToken(token);

                    logger.LogInformation("Exit : GenerateToken()");
                    return Ok(jwtToken);
                }
                else
                {
                    logger.LogInformation("Exit : GenerateToken()");
                    return Unauthorized();
                }
            }
            else
            {
                logger.LogInformation("Exit : GenerateToken()");
                return BadRequest();
            }
        }
    }
}

