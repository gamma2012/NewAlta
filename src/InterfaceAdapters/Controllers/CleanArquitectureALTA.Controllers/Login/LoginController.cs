using Alta.DTOs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Alta.Controllers.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]UserDTO user)
        {
            return null;
        }



        //Revisar si es necesario
        [HttpGet("/username/{username}/password/{password}")]

        public async Task<IActionResult> LoginByUsernameAndPassword(string username, string password)
        {
            await HttpContext.SignInAsync(userPrincipal);

            return Ok();
           
        }

        [Authorize]
        [HttpGet("/CheckLogin")]

        public async Task<IActionResult> CheckLogin()
        {
            return null;
        }
    }
}
