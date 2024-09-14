using DummyData.Interface;
using DummyData.Models;
using Microsoft.AspNetCore.Mvc;

namespace DummyData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _userService.GetUsers();
            return Ok(users);
        }
    }
}
