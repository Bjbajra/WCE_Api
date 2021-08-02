using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WCE_Api.Entities;
using WCE_Api.Interfaces;
using WCE_Api.ViewModels;

namespace WCE_Api.Controllers
{
    [ApiController]
    [Route("wce_api/account")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
        ITokenService tokenService, IMapper mapper)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserViewModel model)
        {
            var newUser = _mapper.Map<AppUser>(model);

            /*var newUser = new AppUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email.ToLower(),
                Phone = model.Phone,
                PhoneNumber = model.Phone
            };*/

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            var user = new UserViewModel
            {
                UserName = newUser.UserName,
                Token = _tokenService.CreateToken(newUser)
            };

            return StatusCode(201, user);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.UserName == model.UserName.ToLower());

            if (user == null) return Unauthorized("Invalid username");

            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

            if (!result.Succeeded) return Unauthorized();

            var loggedInUser = new UserViewModel
            {
                UserName = user.UserName,
                Token = _tokenService.CreateToken(user)
            };

            return Ok(loggedInUser);
        }
    }
}