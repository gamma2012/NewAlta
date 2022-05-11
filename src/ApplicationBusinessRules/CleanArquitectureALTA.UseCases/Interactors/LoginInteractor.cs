using Alta.DTOs;
using Alta.EFCore.Repositories;
using Alta.Entities.Interfaces;
using Alta.UseCasesPorts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactors
{
    public class LoginInteractor : ILoginInputPort
    {
        private readonly ILoginOutputPort _loginOutputPort;
        private readonly IUserLoginRepository _loginRepository;
        public LoginInteractor(ILoginOutputPort loginOutputPort, IUserLoginRepository loginRepository)
        {
            _loginOutputPort = loginOutputPort;
            _loginRepository = loginRepository;
        }
        public async Task Handle(UserDTO user)
        {
           bool exists = await _loginRepository.ExistsUserAsync(user.username, user.password);
           if (exists)
            {
                var userClaims = new List<Claim>(){
                    new Claim(ClaimTypes.Name, user.username)
                };

                var grandmaIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                _loginOutputPort.Handle(userPrincipal);
            }
        }
        

    }
}
