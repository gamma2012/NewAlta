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
           
           //returns user dto and if it exists
           await _loginOutputPort.Handle(user, exists);
        }
        

    }
}
