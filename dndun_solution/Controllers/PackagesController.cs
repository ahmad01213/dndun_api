using dndun_solution.Data.Services;
using dndun_solution.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace dndun_solution.Controllers
{
    [ApiController]
    public class PackagesController : ControllerBase
    {
        		private readonly IPackageService _service;
		public PackagesController(IPackageService service) {
			_service = service;
		}

		[HttpGet("packages")]
		public async Task<ActionResult> Get()
		{
		   IEnumerable<Package> Packages = await _service.GetAllAsync();
           return Ok(Packages);
		}

        [Authorize(Roles ="admin")]
        [HttpPost("packages/delete")]
		public async Task<ActionResult> Delete(int id)
		{
		   await _service.DeleteAsync(id);
           return Ok(true);
		}
        
        [Authorize(Roles ="admin")]
        [HttpPost("packages/add")]
		public async Task<ActionResult> Add(Package package)
		{
		   await _service.AddAsync(package);
           return Ok(package);
		}

        [Authorize(Roles ="admin")]
        [HttpPost("packages/update")]
		public async Task<ActionResult> Update(Package package)
		{
		   await _service.UpdateAsync(package.Id,package);
           return Ok(true);
		}
    }
}