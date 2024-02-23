using DynamicPostMan.Infrustructure;
using DynamicPostMan.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicPostMan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddUsers(User users)
        {
            try
            {
                _context.Users.Add(users);
                await _context.SaveChangesAsync();
                return Ok("Users added successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
