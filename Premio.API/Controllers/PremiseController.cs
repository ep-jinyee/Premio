using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Premio.Interfaces;

namespace Premio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremiseController : ControllerBase
    {
        private readonly IPremiseService _premiseService;

        public PremiseController(IPremiseService premiseService)
        {
            _premiseService = premiseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPremises()
        {
            var roles = await _premiseService.GetAllPremiseAsync();
            return Ok(roles);
        }

        [HttpGet("{roleId}")]
        public async Task<IActionResult> GetPremiseById(string roleId)
        {
            var role = await _premiseService.GetPremiseByIdAsync(roleId);
            if (role == null)
                return NotFound();

            return Ok(role);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                return BadRequest("Role name cannot be empty.");

            var success = await _premiseService.CreatePremiseAsync(roleName);
            if (!success)
                return BadRequest("Role already exists.");

            return Ok("Role created successfully.");
        }

        [HttpPut("{roleId}")]
        public async Task<IActionResult> UpdateRole(string roleId, [FromBody] string newRoleName)
        {
            if (string.IsNullOrWhiteSpace(newRoleName))
                return BadRequest("Role name cannot be empty.");

            var success = await _premiseService.UpdatePremiseAsync(roleId, newRoleName);
            if (!success)
                return NotFound("Role not found or update failed.");

            return Ok("Role updated successfully.");
        }

        [HttpDelete("{roleId}")]
        public async Task<IActionResult> DeleteRole(string roleId)
        {
            var success = await _premiseService.DeletePremiseAsync(roleId);
            if (!success)
                return NotFound("Role not found or delete failed.");

            return Ok("Role deleted successfully.");
        }
    }
}
