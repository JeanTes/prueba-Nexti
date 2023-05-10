using Microsoft.AspNetCore.Mvc;
using TcketApi.BusinessLogic;
using TcketApi.Models;

namespace TcketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("AllUsers")]
        public async Task<ActionResult<IEnumerable<User>>> AllUsers()
        {
            return Ok(await _userService.GetAllUsersAsync());
        }

        [HttpGet]
        [Route("ObtenerUser/{id}")]
        public async Task<ActionResult<User>> ObtenerUser(int id)
        {
            var eventItem = await _userService.GetUserByIdAsync(id);

            if (eventItem == null)
            {
                return NotFound();
            }

            return eventItem;
        }

        [HttpPost]
        [Route("EnviarUser")]
        public async Task<ActionResult<User>> PostUser(User userItem)
        {
            await _userService.AddUserAsync(userItem);
            return CreatedAtAction(nameof(ObtenerUser), new { id = userItem.Id }, userItem);
        }

        [HttpPut]
        [Route("ModificaUser/{id}")]
        public async Task<IActionResult> PutUser(int id, User userItem)
        {
            if (id != userItem.Id)
            {
                return BadRequest();
            }

            await _userService.UpdateUserAsync(userItem);
            return NoContent();
        }

      
    }
}
