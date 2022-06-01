using System;
using dndun_solution.Data.ViewModels;
using dndun_solution.Models;

namespace dndun_solution.Data.Services
{
	public interface IUserService
	{
		Task<object> Register(UserForRegister model);
		Task<object> IsUserRegistered(string UserName);
		Task<object> LoginAdmin(AdminForLoginRequest adminForLogin);
		Task<object> LoginUser(UserForLogin model);
		Task<object> RegisterAdmin(UserForRegister model);
	}
}

