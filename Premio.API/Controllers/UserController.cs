using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Premio.Models;

namespace Premio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UserController(PremioDbContext context) : ControllerBase
    {
        public readonly PremioDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }
    }
}
