using System;
using Microsoft.AspNetCore.Identity;

namespace Premio.Interfaces;

public interface IRoleService
{
    Task<IEnumerable<IdentityRole>> GetAllRolesAsync();
    Task<IdentityRole> GetRoleByIdAsync(string roleId);
    Task<bool> CreateRoleAsync(string roleName);
    Task<bool> UpdateRoleAsync(string roleId, string newRoleName);
    Task<bool> DeleteRoleAsync(string roleId);
}
