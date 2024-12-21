using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Premio.Interfaces;

namespace Premio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleService.GetAllRolesAsync();
            return Ok(roles);
        }

        [HttpGet("{roleId}")]
        public async Task<IActionResult> GetRoleById(string roleId)
        {
            var role = await _roleService.GetRoleByIdAsync(roleId);
            if (role == null)
                return NotFound();

            return Ok(role);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                return BadRequest("Role name cannot be empty.");

            var success = await _roleService.CreateRoleAsync(roleName);
            if (!success)
                return BadRequest("Role already exists.");

            return Ok("Role created successfully.");
        }

        [HttpPut("{roleId}")]
        public async Task<IActionResult> UpdateRole(string roleId, [FromBody] string newRoleName)
        {
            if (string.IsNullOrWhiteSpace(newRoleName))
                return BadRequest("Role name cannot be empty.");

            var success = await _roleService.UpdateRoleAsync(roleId, newRoleName);
            if (!success)
                return NotFound("Role not found or update failed.");

            return Ok("Role updated successfully.");
        }

        [HttpDelete("{roleId}")]
        public async Task<IActionResult> DeleteRole(string roleId)
        {
            var success = await _roleService.DeleteRoleAsync(roleId);
            if (!success)
                return NotFound("Role not found or delete failed.");

            return Ok("Role deleted successfully.");
        }
    }
}
