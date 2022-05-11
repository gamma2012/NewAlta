using Alta.DTOs;
using Alta.Presenters.Interfaces;
using Alta.Presenters.Presenters;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Alta.Controllers.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly ILoginOutputPort _loginOutputPort;

        public LoginController(ILoginOutputPort loginOutputPort)
        {
            _loginOutputPort = loginOutputPort;
        }



        [HttpPost]
        public async Task<IActionResult> Login([FromBody]UserDTO user)
        {
            return null;
        }



        //Revisar si es necesario
        [HttpGet("/username/{username}/password/{password}")]

        public async Task<IActionResult> LoginByUsernameAndPassword(string username, string password)
        {
            await HttpContext.SignInAsync(((IPresenter<ClaimsPrincipal>)_loginOutputPort).Content);

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
