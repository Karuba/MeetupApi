
using AutoMapper;
using MeetupApi.Contracts.Dto;
using MeetupApi.Domain.Core.Entities;
using MeetupApi.Services.Interfaces.Authentification;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MeetupApi.Presentation.Controllers.Controllers
{
    [Route("api/authentification")]
    [ApiController]
    public class AuthentificationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IAuthenticationManager _authManager;

        public AuthentificationController(IMapper mapper, UserManager<User> userManager, IAuthenticationManager authManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _authManager = authManager;
        }
        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDto userRegistration)
        {
            var user = _mapper.Map<User>(userRegistration);
            var result = await _userManager.CreateAsync(user, userRegistration.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            await _userManager.AddToRolesAsync(user, userRegistration.Roles);
            return StatusCode(201);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserAuthenticationDto user)
        {
            if (!await _authManager.ValidateUser(user))
            {
                string warn = $"{nameof(Authenticate)}: Authentication failed. Wrong user name or password.";
                return Unauthorized(warn);
            }
            return Ok(new { Token = await _authManager.CreateToken() });
        }
    }
}
