using System;
using System.Threading.Tasks;
using Assignment2WebAPI.Data;
using Assignment2WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2WebAPI.Controllers
{
    [ApiController]
    [Route("/Users")]
    public class UsersController : ControllerBase
    {

        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [ProducesResponseType(statusCode:400)]
        [ProducesResponseType(statusCode:200)]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string username, [FromQuery] string password)
        {
            Console.WriteLine("Here");
            try
            {
                var user = await userService.ValidateUser(username, password);
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        
        [HttpPost]
        [ProducesResponseType(statusCode:400)]
        [ProducesResponseType(statusCode:500)]
        [ProducesResponseType(statusCode:200)]
        public async Task<ActionResult<User>> AddUser([FromBody] User user) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try {
                User registered = await userService.RegisterUser(user);
                return Created($"/{registered.UserName}",registered); 
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
    }
}
