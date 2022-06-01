using dndun_solution.Data.Services;
using dndun_solution.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GoData.Controllers
{
	[ApiController]
	public class UsersController :ControllerBase
	{
		private readonly IUserService? _service;
		public UsersController(IUserService service) {
			_service = service;
		}

		[HttpPost("check-username")]
		public async Task<Object> IsUserRegistered(string UserName)
		{
			var result = await _service!.IsUserRegistered(UserName);
			return Ok(result);
		}

		[HttpPost("signup")]
		public async Task<ActionResult> Register(UserForRegister userForRegister)
		{
			dynamic result = await _service!.Register(userForRegister);
            if (result.status == false)
            {
				return BadRequest(result);
            }
			return Ok(result);
		}

		[HttpPost("user-login")]
		public async Task<IActionResult> LoginUser(UserForLogin userForLogin)
		{
			dynamic result = await _service!.LoginUser(userForLogin);
			if (result.status == false)
			{
				return Unauthorized();
			}
			return Ok(result);
		}

		[HttpPost("admin-signup")]
		public async Task<ActionResult> RegisterAdmin(UserForRegister userForRegister)
		{
			dynamic result = await _service!.RegisterAdmin(userForRegister);
			if (result.status == true)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost("admin-login")]
		public async Task<IActionResult> LoginAdmin(AdminForLoginRequest adminForLogin)
		{
			dynamic result = await _service!.LoginAdmin(adminForLogin);
            if (result.status == false)
            {
				return Unauthorized();
            }
			return Ok(result);
		}
	}
	}

