using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedRepositories;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IApplicationContext _context;

        public UsersController(IApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsersAsync()
        {
            var usersList = await _context.Users
                .Where(x=>x.IsActive)
                .ToListAsync();

            if (usersList == null || usersList.Count == 0)
            {
                return NotFound("No users found.");
            }

            return Ok(usersList);
        }

    }
}
