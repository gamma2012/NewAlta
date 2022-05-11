using Alta.DTOs;
using Alta.UseCasesPorts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactors
{
    public class LoginInteractor : ILoginInputPort
    {
        private readonly ILoginOutputPort _loginOutputPort;
        public LoginInteractor(ILoginOutputPort loginOutputPort)
        {
            _loginOutputPort = loginOutputPort;
        }
        public Task Handle(UserDTO user)
        {

            throw new NotImplementedException();
        }
    }
}
